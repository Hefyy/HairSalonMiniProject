using System.Collections.Generic;

namespace CutNgoDomain.chris;

public static class SalonData
{
    public static List<Customer> Customers { get; } = new()
    {
        new Customer { Id = 1, Name = "Anna" },
        new Customer { Id = 2, Name = "Bob" }
    };

    public static List<Employee> Employees { get; } = new()
    {
        new Employee { Id = 1, Name = "Lisa", Role = "Frisør" },
        new Employee { Id = 2, Name = "Peter", Role = "Frisør" }
    };

    public static List<Booking> Bookings { get; } = new()
    {
        new Booking() { Id = 1, CustomerId = 1, EmployeeId = 1, TreatmentType = "color", Date = new DateTime(2026, 2, 1, 10, 0, 0)},
        new Booking() { Id = 2, CustomerId = 2, EmployeeId = 2, TreatmentType= "cut", Date = new DateTime(2026, 2, 2, 12, 0, 0)},
    };
}
