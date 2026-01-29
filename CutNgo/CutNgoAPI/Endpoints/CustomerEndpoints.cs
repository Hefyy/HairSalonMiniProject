using CutNgoDomain.Hefy.MockData;
using CutNgoDomain.Hefy.Models;
using CutNgoDomain.Hefy.Models.Enums;
namespace CutNgoAPI.Endpoints;

public static class CustomerEndpoints
{
    public static void MapCustomerEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/appointments").WithTags("Appointments");

        group.MapPost("/", (int customerId, int employeeId, int treatmentId, DateTime date, string note) =>
        {
            var salon = DemoDataFactory.Create();

            try
            {

                var customer = salon.Customers.First(c => c.Id == customerId);
                var employee = salon.Staff.First(e => e.Id == employeeId);
                var treatment = salon.Treatments.First(t => t.Id == treatmentId);

                var end = date.Add(treatment.Duration);

                var appointment = new Appointment
                {
                    Id = Guid.NewGuid(),
                    CustomerId = customer.Id,
                    CustomerName = customer.Name,
                    EmployeeName = employee.Name,
                    EmployeeId = employee.Id,
                    Treatment = treatment,
                    Start = date,
                    End = end,
                    Status = AppointmentStatuses.Booked,
                    Note = note
                };

                salon.Appointments.Add(appointment);

                return Results.Ok(appointment);
            }
            catch (InvalidOperationException)
            {
                return Results.NotFound("Customer, employee or treatment not found");
            }

        });
    }
}
