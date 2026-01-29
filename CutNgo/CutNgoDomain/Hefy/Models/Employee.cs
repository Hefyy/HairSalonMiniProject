using CutNgoDomain.Hefy.Models.Enums;

namespace CutNgoDomain.Hefy.Models;

public class Employee
{
    public int Id { get; set; }
    public Roles Role { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
