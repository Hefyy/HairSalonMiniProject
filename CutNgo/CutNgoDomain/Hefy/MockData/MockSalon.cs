using CutNgoDomain.Hefy.Models;

namespace CutNgoDomain.Hefy.MockData;

class MockSalon
{
    public List<Employee> Staff { get; } = [];
    public List<Customer> Customers { get; } = [];
    public List<Treatment> Treatments { get; } = [];
    public List<Appointment> Appointments { get; } = [];
    

    public IEnumerable<Appointment> GetDailySchedule(Guid employeeId, DateOnly date)
    {
        return Appointments
            .Where(a => a.EmployeeId == employeeId)
            .Where(a => DateOnly.FromDateTime(a.Start) == date)
            .OrderBy(a => a.Start);
    }
}

