using FastEndpoints;
using SiceiApi.CORE.Interfaces.Services;
using SiceiApi.DOMAIN.Responses;

namespace SiceiApi.API.Endpoints
{
    public class GetAllAlumnosEndpoint : EndpointWithoutRequest<GetAllAlumnosReponse>
    {

        private readonly IAlumnosService _alumnosService;

        public GetAllAlumnosEndpoint(IAlumnosService alumnosService)
        {
            _alumnosService = alumnosService;
        }

        public override void Configure()
        {
            Get("/api/alumnos/getAll");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var response = await _alumnosService.GetAllAsync();
            await SendAsync(response);
        }

    }
}
