using FastEndpoints;
using SiceiApi.DOMAIN.Responses;

namespace SiceiApi.API.Endpoints
{
    public class HealtEndpoint : EndpointWithoutRequest<HealtResponse>
    {
        public override void Configure()
        {
            Get("/api/healt");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            await SendAsync(new()
            {
                Status = "OK"
            });
        }

    }
}
