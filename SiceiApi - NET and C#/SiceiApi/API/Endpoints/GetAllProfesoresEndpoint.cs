using FastEndpoints;
using SiceiApi.CORE.Interfaces.Services;
using SiceiApi.DOMAIN.Responses;

namespace SiceiApi.API.Endpoints
{
    public class GetAllProfesoresEndpoint : EndpointWithoutRequest<GetAllProfesoresResponse>
    {

        private readonly IProfesoresService _profesoresService;
        public GetAllProfesoresEndpoint(IProfesoresService profesoresService)
        {
            _profesoresService = profesoresService;
        }

        public override void Configure()
        {
            Get("/api/profesores/getAll");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var response = await _profesoresService.GetAll();
            await SendAsync(response);
        }


    }
}
