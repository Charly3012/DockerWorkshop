using SiceiApi.DOMAIN.Responses;

namespace SiceiApi.CORE.Interfaces.Services
{
    public interface IAlumnosService
    {
        Task<GetAllAlumnosReponse> GetAllAsync();
    }
}
