using SiceiApi.CORE.Interfaces.Repositories;
using SiceiApi.DOMAIN.Models;

namespace SiceiApi.DATA.Repository
{
    public class ProfesorsRepository : IProfesorsRepository
    {
        public Task<IEnumerable<Profesores>> GetAll()
        {
            var response = new List<Profesores>()
            {
                new Profesores { Name = "Eudardo Rodriguez", EmployeeId = 222124 },
                new Profesores { Name = "Cinthia Segura", EmployeeId = 123235 },
                new Profesores { Name = "Michel Garcia", EmployeeId = 823782 },
                new Profesores { Name = "Victor Manuel", EmployeeId = 123739 },
                new Profesores { Name = "Carlos Coronado", EmployeeId = 830672 },
                new Profesores { Name = "Lizzie Sanchez", EmployeeId = 993775 },
                new Profesores { Name = "Carlos Palma", EmployeeId = 229035 }
            };

            return Task.FromResult<IEnumerable<Profesores>>(response);
        }
    }
}
