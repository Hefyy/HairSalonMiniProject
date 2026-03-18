using CutNgoDomain.Models;
using CutNgoDomain.Models.Enums;

namespace CutNgoDomain.MockData;

public static class SalonData
{
    public static List<Customer> Customers { get; } = new()
    {
        new Customer { 
            Id = 1, Name = "Anna", Email = "anna@mail.com", Password = "Anna123" },
        new Customer { Id = 2, Name = "Bob", Email = "bob@mail.com", Password = "Bob123" }
    };

    public static List<Employee> Employees { get; } = new()
    {
        new Employee { Id = 1, Name = "Kaethe", Role = Roles.Owner },
        new Employee { Id = 2, Name = "Lisa", Role = Roles.Manager  },
        new Employee { Id = 3, Name = "Peter", Role = Roles.Stylist },
        new Employee { Id = 4, Name = "John", Role = Roles.Apprentice }
    };

    public static List<Treatment> Treatments { get; } = new()
    {
        //to be changed!!
        new Treatment() { Id = 1, TreatmentTitle = "Cut", Duration = TimeSpan.FromMinutes(30), Price = 500 },
        new Treatment() { Id = 2, TreatmentTitle = "Color", Duration = TimeSpan.FromMinutes(60), Price = 1500 },
        new Treatment() { Id = 3, TreatmentTitle = "Style", Duration = TimeSpan.FromMinutes(45), Price = 450 }
    };

    public static List<Booking> Bookings { get; } = new()
    {
        new Booking() { Id = 1, CustomerId = 1, EmployeeId = 2, TreatmentId = 1, Date = new DateTime(2026, 2, 1, 10, 0, 0), Status = BookingStatuses.Completed},
        new Booking() { Id = 2, CustomerId = 2, EmployeeId = 2, TreatmentId = 2, Date = new DateTime(2026, 2, 2, 12, 0, 0), Status = BookingStatuses.Completed},
    };
}
