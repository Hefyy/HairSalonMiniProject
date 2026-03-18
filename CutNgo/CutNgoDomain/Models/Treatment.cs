namespace CutNgoDomain.Models;

public class Treatment
{
    public int Id { get; set; }
    public string Klipning { get; set; } = string.Empty;
    public string Permanent { get; set; } = string.Empty;
    public string Striber { get; set; } = string.Empty;
    public string Helfarvning { get; set; } = string.Empty;
    public TimeSpan Duration { get; set; }
    public decimal Price { get; set; }
}
