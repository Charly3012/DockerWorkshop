using SiceiApi.DOMAIN.Models;
using SiceiApi.DOMAIN.Responses;

namespace SiceiApi.CORE.Interfaces.Services
{
    public interface IProfesoresService
    {
        Task<GetAllProfesoresResponse> GetAll();
    }
}
