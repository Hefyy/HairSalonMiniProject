//using CutNgoDomain.Hefy.Models;

//namespace CutNgoDomain.Hefy.MockData;

//static class DemoDataFactory
//{
//    public static MockSalon Create()
//    {
//        var salon = new MockSalon();

//        var staff = new[]
//        {
//            new Employee { Id = Guid.NewGuid(), Name = "Kæthe", Role = Models.Enums.Roles.Owner },
//            new Employee { Id = Guid.NewGuid(), Name = "Anna", Role = Models.Enums.Roles.Manager },
//            new Employee { Id = Guid.NewGuid(), Name = "Mikkel", Role = Models.Enums.Roles.Stylist },
//            new Employee { Id = Guid.NewGuid(), Name = "Sofie", Role = Models.Enums.Roles.Apprentice }
//        };

//        var customer = new[]
//        {
//            new Customer {Id = Guid.NewGuid(), Name = "Emma" },
//            new Customer {Id = Guid.NewGuid(), Name = "Noah" },
//            new Customer {Id = Guid.NewGuid(), Name = "Freja" }
//        };

//        var treatment = new[]
//        {
//            new Treatment { Id = Guid.NewGuid(), TreatmentTitle = "Herreklip", Duration = new TimeSpan(0,45,0), Price = 180 },
//            new Treatment { Id = Guid.NewGuid(), TreatmentTitle = "Dameklip", Duration = new TimeSpan(0,60,0), Price = 250 },
//            new Treatment { Id = Guid.NewGuid(), TreatmentTitle = "Børneklip", Duration = new TimeSpan(0,30,0), Price = 170 }
//        };

//        salon.Staff.AddRange(staff);
//        salon.Customers.AddRange(customer);
//        salon.Treatments.AddRange(treatment);

//        var today = DateOnly.FromDateTime(DateTime.Today);

//        foreach (var employee in staff)
//        {
//            GenerateDay(salon, employee.Id, today);
//            GenerateDay(salon, employee.Id, today.AddDays(1));
//        }

//        return salon;
//    }

//    static void GenerateDay(
//        MockSalon salon,
//        Guid employeeId,
//        DateOnly date)
//    {
//        var start = date.ToDateTime(new TimeOnly(9, 0));
//        var rnd = new Random();

//        for (int i = 0; i < 6; i++)
//        {
//            var duration = rnd.Next(30, 90); // minutter
//            var end = start.AddMinutes(duration);

//            salon.Appointments.Add(new Appointment
//            {
//                Id = Guid.NewGuid(),
//                EmployeeId = employeeId,
//                Start = start,
//                End = end,
//                Customer = FakeCustomer()
//            });

//            start = end.AddMinutes(15); // pause
//        }
//    }

//    static string FakeCustomer()
//    {
//        string[] names =
//        {
//            "Emma", "Noah", "Freja", "Oscar",
//            "Ida", "Lucas", "Signe", "William"
//        };

//        return names[Random.Shared.Next(names.Length)];
//    }














//    static void GenerateDay(
//    MockSalon salon,
//    Guid employeeId,
//    DateOnly date)
//    {
//        var rnd = new Random();

//        // Definér arbejdstid: 9:00 til 17:00
//        var workStart = new TimeOnly(9, 0);
//        var workEnd = new TimeOnly(17, 0);

//        var appointmentsForDay = new List<Appointment>();

//        for (int i = 0; i < 3; i++) // 3 aftaler per dag
//        {
//            // Vælg en random behandling
//            var treatment = salon.Treatments[rnd.Next(salon.Treatments.Count)];

//            // Beregn random starttid, så aftalerne ligger indenfor arbejdstiden
//            TimeOnly start;
//            int attempt = 0;
//            do
//            {
//                int totalMinutes = rnd.Next(0, (workEnd.Hour * 60 + workEnd.Minute) - (workStart.Hour * 60 + workStart.Minute) - (int)treatment.Duration.TotalMinutes);
//                start = workStart.AddMinutes(totalMinutes);
//                attempt++;
//                // Simpel overlap-check
//            } while (appointmentsForDay.Any(a => a.Start < start.AddMinutes(treatment.Duration.TotalMinutes) && start < a.End) && attempt < 10);

//            var end = start.AddMinutes(treatment.Duration.TotalMinutes);

//            // Vælg en random kunde
//            var customer = salon.Customers[rnd.Next(salon.Customers.Count)];

//            appointmentsForDay.Add(new Appointment
//            {
//                Id = Guid.NewGuid(),
//                EmployeeId = employeeId,
//                CustomerId = customer.Id,
//                TreatmentId = treatment.Id,
//                Start = date.ToDateTime(start),
//                End = date.ToDateTime(end)
//            });
//        }

//        salon.Appointments.AddRange(appointmentsForDay);
//    }

//}

