using SiceiApi.CORE.Interfaces.Repositories;
using SiceiApi.CORE.Interfaces.Services;
using SiceiApi.DOMAIN.Models;
using SiceiApi.DOMAIN.Responses;

namespace SiceiApi.CORE.Services
{
    public class ProfesorService : IProfesoresService
    {
        private readonly IProfesorsRepository _profesoresRepository;

        public ProfesorService(IProfesorsRepository profesoresRepository)
        {
            _profesoresRepository = profesoresRepository;
        }

        public async Task<GetAllProfesoresResponse> GetAll()
        {

            return new()
            {
                Profesores = await _profesoresRepository.GetAll()
            };
        }
    }
}
