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
        public async Task<Administrador?> Add(Administrador administrador)
        {
            return await _repository.AddAsync(administrador);
        }
        public async Task<Administrador> GetByNome(string nome)
        {
            return await _repository.GetByNomeAsync(nome);
        }
        public async Task<Administrador?> Post(int id, Administrador administrador) 
        {
            return await _repository.PostAsync(id, administrador);
        }
        public async Task<Administrador?> Delete(int id) 
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
