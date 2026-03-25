using CutNgoDomain.Models.Enums;

namespace CutNgoDomain.Models;

public class Booking
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int CustomerId { get; set; }
    public int EmployeeId { get; set; }
    public int TreatmentId { get; set; }
    public int SalonId { get; set; }
    public BookingStatuses Status { get; set; }
}
