using CorretoraJenissonLuckwuAPI.Context;
using CorretoraJenissonLuckwuAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CorretoraJenissonLuckwuAPI.Controller
{
  [ApiController]
  [Route("[controller]")]
  public class AdministradorController : ControllerBase
  {
    #region Variables
    private readonly CorretoraJenissonLuckwuDb _context;
    #endregion

    #region Constructors
    public AdministradorController(CorretoraJenissonLuckwuDb context)
    {
      _context = context;
    }
    #endregion

    #region Controllers
    [HttpPost("PostAdministrador")]
    public IActionResult PostAdm(Administrador administrador)
    {
      _context.Administradores.Add(administrador);
      _context.SaveChanges();
      return Ok(administrador);
    }

    [HttpGet("GetAdministradoresId/{id}")]
    public IActionResult GetAdmId(int id)
    {
      var administrador = _context.Administradores.Find(id);
      if (administrador == null)
        return NotFound("Administrador não encontrado");
      return Ok(administrador);
    }

    [HttpGet("ListarAdministradores")]
    public IActionResult ListarAdms(string nome)
    {
      var AdministradoresBanco = _context.Administradores.Where(x => x.Nome.Contains(nome)).ToList();
      return Ok(AdministradoresBanco);
    }

    [HttpPut("AtualizarAdministrador/{id}")]
    public IActionResult AtualizarAdm(int id, Administrador administrador)
    {
      var AdministradorBanco = _context.Administradores.Find(id);

      if (AdministradorBanco == null)
        return NotFound("Administrador não existe");

      AdministradorBanco.Nome = administrador.Nome;
      AdministradorBanco.Email = administrador.Email;
      AdministradorBanco.Telefone = administrador.Telefone;
      AdministradorBanco.Senha = administrador.Senha;
      AdministradorBanco.ID_PFPJ = administrador.ID_PFPJ;
      AdministradorBanco.Updated_at = DateTime.UtcNow;

      _context.Administradores.Update(AdministradorBanco);
      _context.SaveChanges();

      return Ok(AdministradorBanco);
    }
    [HttpDelete("DeletarAdministrador/{id}")]
    public IActionResult DeletarAdm(int id)
    {
      var AdministradorBanco = _context.Administradores.Find(id);
      if (AdministradorBanco == null)
        return NotFound("Administrador não existe");

      _context.Administradores.Remove(AdministradorBanco);
      _context.SaveChanges();

      return Ok("Administrador deletado com sucesso");
    }
    #endregion
  }
}
