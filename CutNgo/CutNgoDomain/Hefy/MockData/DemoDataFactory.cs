using CutNgoDomain.Hefy.Models;

namespace CutNgoDomain.Hefy.MockData;

public static class DemoDataFactory
{
    public static MockSalon Create()
    {
        var salon = new MockSalon();

        var staff = new[]
        {
            new Employee { Id = 1, Name = "Kæthe", Role = Models.Enums.Roles.Owner },
            new Employee { Id = 2, Name = "Anna", Role = Models.Enums.Roles.Manager },
            new Employee { Id = 3, Name = "Mikkel", Role = Models.Enums.Roles.Stylist },
            new Employee { Id = 4, Name = "Sofie", Role = Models.Enums.Roles.Apprentice }
        };

        var customer = new[]
        {
            new Customer {Id = 1, Name = "Emma" },
            new Customer {Id = 2, Name = "Noah" },
            new Customer {Id = 3, Name = "Freja" }
        };

        var treatment = new[]
        {
            new Treatment { Id = 1, TreatmentTitle = "Herreklip", Duration = new TimeSpan(0,45,0), Price = 180 },
            new Treatment { Id = 2, TreatmentTitle = "Dameklip", Duration = new TimeSpan(0,60,0), Price = 250 },
            new Treatment { Id = 3, TreatmentTitle = "Børneklip", Duration = new TimeSpan(0,30,0), Price = 170 }
        };

        salon.Staff.AddRange(staff);
        salon.Customers.AddRange(customer);
        salon.Treatments.AddRange(treatment);
        
        return salon;
    }
   
}

