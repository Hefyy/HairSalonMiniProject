using CutNgoDomain.chris;

namespace CutNgoAPI.Endpoints;

public static class CustomerEndpoints
{
    public static void MapCustomerEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/customers", () => { return SalonData.Customers; });
        
    }
}
