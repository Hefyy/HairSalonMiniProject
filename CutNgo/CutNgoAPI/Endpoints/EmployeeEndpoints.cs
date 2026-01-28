namespace CutNgoAPI.Endpoints;

public static class EmployeeEndpoints
{
    public static void MapEmployeeEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/employees", () => "Get all employees");
        app.MapGet("/employees/{id}", (int id) => $"Get employee with ID {id}");
        app.MapPost("/employees", () => "Create a new employee");
        app.MapPut("/employees/{id}", (int id) => $"Update employee with ID {id}");
        app.MapDelete("/employees/{id}", (int id) => $"Delete employee with ID {id}"); 
       

    }
}
