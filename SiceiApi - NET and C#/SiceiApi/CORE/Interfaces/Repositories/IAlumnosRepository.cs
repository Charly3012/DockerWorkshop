using SiceiApi.DOMAIN.Models;

namespace SiceiApi.CORE.Interfaces.Repositories
{
    public interface IAlumnosRepository
    {
        Task<IEnumerable<Alumno>> GetAllAsync();
    }
}
