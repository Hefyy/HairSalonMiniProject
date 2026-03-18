using CutNgoDomain.Models.Enums;

namespace CutNgoDomain.Models;

public class Employee
{
    public int Id { get; set; }
    public Roles Role { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<Booking> Appointments { get; set; } = new List<Booking>();
}
