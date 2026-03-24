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
        
        new Treatment() { Id = 1, TreatmentTitle = "Klip: Herrer", Duration = TimeSpan.FromMinutes(30), Price = 180 },
        new Treatment() { Id = 2, TreatmentTitle = "Klip: Dame", Duration = TimeSpan.FromMinutes(60), Price = 250 },
        new Treatment() { Id = 3, TreatmentTitle = "Klip: Børn (under 12 år)", Duration = TimeSpan.FromMinutes(30), Price = 170 },
        new Treatment() { Id = 4, TreatmentTitle = "Klip: Herrer (pensionist)", Duration = TimeSpan.FromMinutes(30), Price = 170 },
        new Treatment() { Id = 5, TreatmentTitle = "Klip: Dame (pensionist)", Duration = TimeSpan.FromMinutes(30), Price = 230 },

        new Treatment() { Id = 6, TreatmentTitle = "Permanent: Kort fra", Duration = TimeSpan.FromMinutes(60), Price = 550 },
        new Treatment() { Id = 7, TreatmentTitle = "Permanent: Mellem", Duration = TimeSpan.FromMinutes(90), Price = 750 },
        new Treatment() { Id = 8, TreatmentTitle = "Permanent: Langt fra", Duration = TimeSpan.FromMinutes(120), Price = 950 },

        new Treatment() { Id = 9, TreatmentTitle = "Striber: Kort fra", Duration = TimeSpan.FromMinutes(60), Price = 550 },
        new Treatment() { Id = 10, TreatmentTitle = "Striber: Mellem", Duration = TimeSpan.FromMinutes(60), Price = 700 },
        new Treatment() { Id = 11, TreatmentTitle = "Striber: Langt fra", Duration = TimeSpan.FromMinutes(90), Price = 850 },
        new Treatment() { Id = 12, TreatmentTitle = "Striber: Hætte striber", Duration = TimeSpan.FromMinutes(45), Price = 400 },

        new Treatment() { Id = 13, TreatmentTitle = "Helfarvning: Kort", Duration = TimeSpan.FromMinutes(45), Price = 450 },
        new Treatment() { Id = 14, TreatmentTitle = "Helfarvning: Mellem", Duration = TimeSpan.FromMinutes(60), Price = 600 },
        new Treatment() { Id = 15, TreatmentTitle = "Helfarvning: Langt", Duration = TimeSpan.FromMinutes(80), Price = 700 },
        new Treatment() { Id = 16, TreatmentTitle = "toning- bund 2-3 cm", Duration = TimeSpan.FromMinutes(45), Price = 350}
    };

    public static List<Booking> Bookings { get; } = new()
    {
        new Booking() { Id = 1, CustomerId = 1, EmployeeId = 2, TreatmentId = 1, Date = new DateTime(2026, 2, 1, 10, 0, 0), Status = BookingStatuses.Completed},
        new Booking() { Id = 2, CustomerId = 2, EmployeeId = 2, TreatmentId = 2, Date = new DateTime(2026, 2, 2, 12, 0, 0), Status = BookingStatuses.Completed},
    };

    public static List<Salon> Salons { get; } = new()
    {
        new Salon() { Id = 1, Name = "Salon Runde Tårn", Address = "Frederiksgade 1", City = "Aarhus", ZipCode = "8000", Latitude = 56.154, Longitude = 10.203 },
        new Salon() { Id = 2, Name = "Salon H.C. Andersens Skæve Hus", Address = "Overgade 24", City = "Odense", ZipCode = "5000", Latitude = 55.399, Longitude = 10.383 }
    };
}
