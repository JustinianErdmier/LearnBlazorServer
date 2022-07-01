namespace BlazorApp.Data;

public class WeatherForecastService
{
    private static readonly string[] Summaries =
    {
        "Freezing",
        "Bracing",
        "Chilly",
        "Cool",
        "Mild",
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching"
    };

    private readonly ILogger<WeatherForecastService> _logger;

    private readonly IConfiguration _configuration;

    public WeatherForecastService(ILogger<WeatherForecastService> logger, IConfiguration configuration)
    {
        _logger        = logger;
        _configuration = configuration;
    }

    public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
    {
        _logger.LogInformation("Getting the forecast");

        int upperValue = _configuration.GetValue<int>("WeatherForecast:ForecastDays");

        return Task.FromResult(Enumerable.Range(1, upperValue)
                                         .Select(index => new WeatherForecast
                                                          {
                                                              Date         = startDate.AddDays(index),
                                                              TemperatureC = Random.Shared.Next(-20, 55),
                                                              Summary      = Summaries[Random.Shared.Next(Summaries.Length)]
                                                          })
                                         .ToArray());
    }
}
