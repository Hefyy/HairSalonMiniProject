namespace CutNgoDomain.chris;

public class Booking
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int CustomerId { get; set; }
    public int EmployeeId { get; set; }
    public string TreatmentType { get; set; }
}
