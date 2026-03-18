
using CutNgoDomain.chris;

namespace CutNgoAPI.Endpoints;

public static class BookingEndpoints
{
    public static void MapBookingEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/bookings").WithTags("Bookings");

        group.MapPost("/", (Booking booking) =>
        {
            booking.Id = SalonData.Bookings.Count > 0 ? SalonData.Bookings.Max(b => b.Id) + 1 : 1;
            
            SalonData.Bookings.Add(booking);
            return Results.Created($"/api/bookings/{booking.Id}", booking);
        });
        group.MapGet("/{bookingId}", (int bookingId) =>
        {
            var booking = SalonData.Bookings.FirstOrDefault(b => b.Id == bookingId);
            return booking is not null ? Results.Ok(booking) : Results.NotFound();
        });

        group.MapGet("/all", () => { return SalonData.Bookings; });

        group.MapGet("/day/{date}", (DateTime date) => { return SalonData.Bookings.Where(b => b.Date.Date == date.Date).ToList();
        });

        group.MapGet("/week/{weekNumber}", (int weekNumber) => { return SalonData.Bookings.Where(b => System.Globalization.ISOWeek.GetWeekOfYear(b.Date) == weekNumber).ToList(); });

        group.MapGet("/customer{customer}", (string customer) => { return SalonData.Bookings.Where(b => SalonData.Customers.Any (c => c.Id == b.CustomerId && c.Name.Equals (customer, StringComparison.OrdinalIgnoreCase))).ToList(); });

        group.MapGet("/employee{employee}", (string employee) => {  return SalonData.Bookings.Where(b => SalonData.Employees.Any (c => c.Id == b.EmployeeId && c.Name.Equals (employee, StringComparison.OrdinalIgnoreCase))).ToList(); }); 
    }
}
