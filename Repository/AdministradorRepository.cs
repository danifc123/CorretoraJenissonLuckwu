using CorretoraJenissonLuckwuAPI.EFModel.Configurations;
using CorretoraJenissonLuckwuAPI.Models;

namespace CorretoraJenissonLuckwuAPI.Repository
{
    public class AdministradorRepository
    {
        private readonly CorretoraJenissonLuckwuDb _context;

        public AdministradorRepository(CorretoraJenissonLuckwuDb context)
        {
            _context = context;
        }

        public async Task<Administrador?> GetByIdAsync(int id)
        {
           return await _context.Administradores.FindAsync(id);
        }
    }
}
