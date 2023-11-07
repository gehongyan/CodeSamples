// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using System.Text.Json.Serialization;

Console.WriteLine("1");

JsonSerializer.Serialize(new WeatherForecast(), SourceGenerationContext.Default.WeatherForecast);

public class WeatherForecast
{
    public DateTime Date { get; set; }
    public int TemperatureCelsius { get; set; }
    public string? Summary { get; set; }
}

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(WeatherForecast))]
internal partial class SourceGenerationContext : JsonSerializerContext
{
}
