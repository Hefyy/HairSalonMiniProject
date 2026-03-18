using CutNgoDomain.MockData;

namespace CutNgoAPI.Endpoints;

public static class EmployeeEndpoints
{
    public static void MapEmployeeEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/employees").WithTags("Staff");

        group.MapGet("/", () => { return SalonData.Employees; });

    }
}
