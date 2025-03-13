using SiceiApi.DOMAIN.Models;

namespace SiceiApi.DOMAIN.Responses
{
    public class GetAllAlumnosReponse
    {
        public IEnumerable<Alumno> Alumnos { get; set; }
    }
}
