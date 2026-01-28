using CutNgoDomain.chris;

namespace CutNgoDomain.Services;

public class MockDataService
{
    public List<Customer> GetCustomers()
    {
        return SalonData.Customers;
    }

    public List<Booking> GetBookings()
    {
        return SalonData.Bookings;
    }

}
