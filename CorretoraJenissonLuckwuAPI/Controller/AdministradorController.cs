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
        [HttpPost("CriarAdministrador")]
        public IActionResult CriarAdm(Administrador administrador) 
        { 
            _context.Administradores.Add(administrador);
            _context.SaveChanges();
            return Ok(administrador);
        }

        #endregion
    }
}
