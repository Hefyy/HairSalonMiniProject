using CutNgoDomain.chris;

namespace CutNgoAPI.Endpoints;

public static class EmployeeEndpoints
{
    public static void MapEmployeeEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/employees", () => { return SalonData.Employees; });

    }
}
