using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public ActionResult<IEnumerable<string>> Get()
    {
        try
        {
            var div = 0;
            var test = 1 / div;
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw;
        }
        _logger.LogInformation("method called");
        return Ok(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray());
    }
}

