using SiceiApi.DOMAIN.Models;

namespace SiceiApi.DOMAIN.Responses
{
    public class GetAllProfesoresResponse
    {
        public IEnumerable<Profesores> Profesores { get; set; }
    }
}
