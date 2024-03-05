using Microsoft.AspNetCore.Mvc;
using ChristopherBriddock.ApiEndpoints;

namespace ChristopherBriddock.ApiEndpoints.Sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : EndpointBaseAsync
                                            .WithRequest<WeatherRequest>
                                            .WithQuery<WeatherRequestQuery>
                                            .WithActionResult
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        public override async Task<ActionResult> HandleAsync([FromBody] WeatherRequest request,
                                                             [FromQuery] WeatherRequestQuery param,
                                                             CancellationToken cancellationToken = default)
        {
            // For example: https://localhost:7080/weather?City="London"
            return await Task.FromResult(Ok());
        }
    }
}
