namespace CutNgoAPI.Endpoints;

public static class CustomerEndpoints
{
    public static void MapCustomerEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/customers", () => "Get all customers");
        app.MapGet("/customers/{id}", (int id) => $"Get customer with ID {id}");
        app.MapPost("/customers", () => "Create a new customer");
        app.MapPut("/customers/{id}", (int id) => $"Update customer with ID {id}");
        app.MapDelete("/customers/{id}", (int id) => $"Delete customer with ID {id}");
    }
}
