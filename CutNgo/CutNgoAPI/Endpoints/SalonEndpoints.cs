using CutNgoDomain.MockData;

namespace CutNgoAPI.Endpoints;

public static class SalonEndpoints
{
    public static void MapSalonEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/salons").WithTags("Salons");

        group.MapGet("/", () =>
        {
            return SalonData.Salons; 
        });
    }
}
