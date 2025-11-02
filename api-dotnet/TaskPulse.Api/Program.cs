var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer(); // for minimal API metadata
builder.Services.AddControllers();          // we'll use this later for real controllers

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

// Simple in-memory sample data (keep for now so we can test the app runs)
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

// Minimal API test endpoint just so we can confirm it's alive
app.MapGet("/weatherforecast", () =>
    {
        var forecast = Enumerable.Range(1, 8).Select(index =>
            new WeatherForecast(
                DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Random.Shared.Next(-20, 55),
                summaries[Random.Shared.Next(summaries.Length)]
            )
        ).ToArray();

        return Results.Ok(forecast);
    })
    .WithName("GetWeatherForecast");

app.Run();

// this is a small record type used by /weatherforecast
record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}