using Microsoft.AspNetCore.Mvc;
using ChristopherBriddock.ApiEndpoints;

namespace ChristopherBriddock.ApiEndpoints.Sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : EndpointBaseAsync
                                            .WithRequest<WeatherRequest>
                                            .WithParam<WeatherRequestParams>
                                            .WithActionResult
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        public override async Task<ActionResult> HandleAsync([FromBody] WeatherRequest request,
                                                             [FromQuery] WeatherRequestParams param,
                                                             CancellationToken cancellationToken = default)
        {
            return await Task.FromResult(Ok());
        }
    }
}
