using SiceiApi.CORE.Interfaces.Repositories;
using SiceiApi.DOMAIN.Models;

namespace SiceiApi.DATA.Repository
{
    public class AlumnosRepository : IAlumnosRepository
    {
        public Task<IEnumerable<Alumno>> GetAllAsync()
        {
            var response = new List<Alumno>()
        {
            new() { Name = "Carlos Coronado", Id = "22216878" },
            new() { Name = "Itzel", Id = "22216888" },
            new() { Name = "Pedro Sanchez", Id = "22217973" },
            new() { Name = "Jhonatan Solis", Id = "12975925" },
            new() { Name = "Montse Ramirez", Id = "222468345" },
            new() { Name = "Carolina Porter", Id = "12353225" },
            new() { Name = "Jazmin Dzib", Id = "23463325" }
        };

            return Task.FromResult<IEnumerable<Alumno>>(response);

        }
    }
}
