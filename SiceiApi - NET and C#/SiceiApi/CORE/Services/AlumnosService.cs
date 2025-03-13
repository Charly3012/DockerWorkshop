using SiceiApi.CORE.Interfaces.Repositories;
using SiceiApi.CORE.Interfaces.Services;
using SiceiApi.DOMAIN.Responses;

namespace SiceiApi.CORE.Services
{
    public class AlumnosService : IAlumnosService
    {
        private readonly IAlumnosRepository _alumnosRepository;

        public AlumnosService(IAlumnosRepository alumnosRepository)
        {
            _alumnosRepository = alumnosRepository;
        }


        public async Task<GetAllAlumnosReponse> GetAllAsync()
        {
            var alumnos = await _alumnosRepository.GetAllAsync();
            return new GetAllAlumnosReponse
            {
                Alumnos = alumnos
            };

        }
    }
}
