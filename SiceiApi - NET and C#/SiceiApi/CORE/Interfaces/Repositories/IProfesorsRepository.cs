using SiceiApi.DOMAIN.Models;

namespace SiceiApi.CORE.Interfaces.Repositories
{
    public interface IProfesorsRepository
    {
        Task<IEnumerable<Profesores>> GetAll();
    }
}
