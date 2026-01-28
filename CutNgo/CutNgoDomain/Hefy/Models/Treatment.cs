namespace CutNgoDomain.Hefy.Models;

public class Treatment
{
    public Guid Id { get; set; }
    public string TreatmentTitle { get; set; } = string.Empty;
    public TimeSpan Duration { get; set; }
    public decimal Price { get; set; }
}
