using CutNgoDomain.Models;
using CutNgoDomain.MockData;

namespace CutNgoAPI.Endpoints;

public static class TreatmentEndpoints
{
    public static void MapTreatmentEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/treatments").WithTags("Treatments");

        group.MapGet("/", () => { return SalonData.Treatments; });

        group.MapGet("/{treatmentId}", (int treatmentId) =>
        {
            var treatment = SalonData.Treatments.FirstOrDefault(t => t.Id == treatmentId);
            return treatment is not null ? Results.Ok(treatment) : Results.NotFound();
        });
    }
}
