using CutNgoDomain.Hefy.Models.Enums;

namespace CutNgoDomain.Hefy.Models;

public class Appointment
{
    public Guid Id { get; set; }
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; } = string.Empty;
    public Treatment? Treatment { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public AppointmentStatuses Status { get; set; }
    public int? CustomerId { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string? Note { get; set; }
}
