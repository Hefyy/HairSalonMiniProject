
using CutNgoDomain.chris;

namespace CutNgoAPI.Endpoints;

public static class BookingEndpoints
{
    public static void MapBookingEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/bookings", () => { return SalonData.Bookings; });

        app.MapGet("/bookings/day/{date}", (DateTime date) => { return SalonData.Bookings.Where(b => b.Date.Date == date.Date).ToList();
        });

        app.MapGet("/bookings/week/{weekNumber}", (int weekNumber) => { return SalonData.Bookings.Where(b => System.Globalization.ISOWeek.GetWeekOfYear(b.Date) == weekNumber).ToList(); });

        app.MapGet("/bookings/customer{customer}", (string customer) => { return SalonData.Bookings.Where(b => SalonData.Customers.Any (c => c.Id == b.CustomerId && c.Name.Equals (customer, StringComparison.OrdinalIgnoreCase))).ToList(); });

        app.MapGet("/bookings/employee{employee}", (string employee) => {  return SalonData.Bookings.Where(b => SalonData.Employees.Any (c => c.Id == b.EmployeeId && c.Name.Equals (employee, StringComparison.OrdinalIgnoreCase))).ToList(); }); 
    }
}
