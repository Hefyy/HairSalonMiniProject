using CutNgoDomain.Models;
using CutNgoDomain.MockData;

namespace CutNgoAPI.Endpoints;

public static class BookingEndpoints
{
    public static void MapBookingEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/bookings").WithTags("Bookings");

        group.MapPost("/", (Booking booking) =>
        {
            Console.WriteLine($"Booking received: {booking.Date}, {booking.CustomerId}, {booking.EmployeeId}, {booking.TreatmentId}, {booking.Status}");

            booking.Id = SalonData.Bookings.Count > 0 ? SalonData.Bookings.Max(b => b.Id) + 1 : 1;
            
            SalonData.Bookings.Add(booking);

            Console.WriteLine($"Booking Confirmed: {booking.Id}");

            return Results.Created($"/api/bookings/{booking.Id}", booking);
        });

        group.MapGet("/{bookingId}", (int bookingId) =>
        {
            var booking = SalonData.Bookings.FirstOrDefault(b => b.Id == bookingId);
            return booking is not null ? Results.Ok(booking) : Results.NotFound();
        });

        group.MapGet("/{salonId}/{date}", (int salonId, DateOnly date) =>
        {
            var bookings = SalonData.Bookings
                .Where(b =>
                    b.SalonId == salonId &&
                    DateOnly.FromDateTime(b.Date) == date
                );

            return bookings;
        });


        group.MapPut("/{bookingId}", (int bookingId, Booking updatedBooking) =>
        {
            var booking = SalonData.Bookings.FirstOrDefault(b => b.Id == bookingId);

            if (booking is null) return Results.NotFound();

            booking.Date = updatedBooking.Date;
            booking.CustomerId = updatedBooking.CustomerId;
            booking.EmployeeId = updatedBooking.EmployeeId;
            booking.TreatmentId = updatedBooking.TreatmentId;
            booking.Status = updatedBooking.Status;
            if (updatedBooking.ImageUri != null)
            {
                booking.ImageUri = updatedBooking.ImageUri;
            }

            return Results.Ok(booking);
        });

        group.MapDelete("/{bookingId}", (int bookingId) =>
        {
            var booking = SalonData.Bookings.FirstOrDefault(b => b.Id == bookingId);

            if (booking is null) return Results.NotFound();

            SalonData.Bookings.Remove(booking);
            return Results.NoContent();
        });

        group.MapGet("/all", () => { return SalonData.Bookings; });

        group.MapGet("/day/{date}", (DateOnly date) => { return SalonData.Bookings.Where(b => DateOnly.FromDateTime(b.Date) == date).ToList();
        });

        group.MapGet("/week/{weekNumber}", (int weekNumber) => { return SalonData.Bookings.Where(b => System.Globalization.ISOWeek.GetWeekOfYear(b.Date) == weekNumber).ToList(); });

        group.MapGet("/customer{customerId}", (int customerId) => { return SalonData.Bookings.Where(b => SalonData.Customers.Any (c => c.Id == b.CustomerId)).ToList(); });

        group.MapGet("/employee{employeeId}", (string employee) => {  return SalonData.Bookings.Where(b => SalonData.Employees.Any (c => c.Id == b.EmployeeId)).ToList(); }); 
    }
}
