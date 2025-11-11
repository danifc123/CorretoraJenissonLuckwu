using CorretoraJenissonLuckwuAPI.Context;
using CorretoraJenissonLuckwuAPI.Entities;
using CorretoraJenissonLuckwuAPI.Models;
using CorretoraJenissonLuckwuAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CorretoraJenissonLuckwuAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdministradorController : ControllerBase
    {
        #region Variables
        private readonly CorretoraJenissonLuckwuDb _context;
        private readonly AdministradorService _service;
        #endregion


        #region Constructors
        public AdministradorController(CorretoraJenissonLuckwuDb context)
        {
            _context = context;
        }
        #endregion

        #region Controllers
        [HttpPost]
        public async Task<ActionResult<Administrador>> PostAdm(Administrador administrador)
        {
            try
            {
                var result = await _service.Add(administrador);
                if (result == null) return BadRequest("Erro ao adicionar administrador");
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno no servidor: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Administrador>> GetAdmId(int id)
        {
            try
            {
                var result = await _service.GetById(id);
                if (result == null) return NotFound("Administrador não encontrado");
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno no servidor: {ex.Message}");
            }
        }

        [HttpGet("filter")]
        public async Task<ActionResult<Administrador>> GetByNameAdm(string nome)
        {
            try
            {
                var result = await _service.GetByNome(nome);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno no servidor: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Administrador>> AtualizarAdm(int id, Administrador administrador)
        {
            try
            {
                var administradorBanco = await _service.Post(id,administrador);
                return Ok(administradorBanco);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno no servidor: {ex.Message}");
            }

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Administrador>> DeletarAdm(int id)
        {
            try
            {
                var administradorBanco = await _service.Delete(id);

                return Ok("Administrador deletado com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno no servidor: {ex.Message}");
            }
        }
        #endregion
    }
}
