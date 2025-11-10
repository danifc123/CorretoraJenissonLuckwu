using CorretoraJenissonLuckwuAPI.Models;
using CorretoraJenissonLuckwuAPI.Repository;

namespace CorretoraJenissonLuckwuAPI.Services
{
    public class AdministradorService
    {
        private AdministradorRepository _repository;

        public AdministradorService(AdministradorRepository repository)
        {
            _repository = repository;
        }

        public async Task<Administrador?> GetById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
