using CutNgoDomain.Hefy.Models.Enums;

namespace CutNgoDomain.Hefy.Models;

public class Appointment
{
    public Guid Id { get; set; }
    public Guid EmployeeId { get; set; }
    public Employee? Employee { get; set; }
    public Treatment? Treatment { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public AppointmentStatuses Status { get; set; }
    public Guid? CustomerId { get; set; }
    public Customer? Customer { get; set; }
    public string? Notes { get; set; }
}
