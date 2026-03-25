using CutNgoDomain.MockData;
using CutNgoDomain.Models;

namespace CutNgoAPI.Endpoints;

public static class CustomerEndpoints
{
    public static void MapCustomerEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/customers").WithTags("Customers");

        group.MapPost("/", (Customer customer) =>
        {
            customer.Id = SalonData.Customers.Count > 0 ? SalonData.Customers.Max(c => c.Id) + 1 : 1;

            SalonData.Customers.Add(customer);
            return Results.Created($"/api/customers/{customer.Id}", customer);
        });
        group.MapGet("/{customerId}", (int customerId) =>
        {
            var customer = SalonData.Customers.FirstOrDefault(c => c.Id == customerId);
            return customer is not null ? Results.Ok(customer) : Results.NotFound();
        });
        group.MapGet("/all", () => { return SalonData.Customers; });

        group.MapGet("/name/{name}", (string name) => { return SalonData.Customers.Where(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList(); });

        group.MapPut("/{customerId}", (int customerId, Customer updatedCustomer) =>
        {
            var customer = SalonData.Customers.FirstOrDefault(c => c.Id == customerId);
            if (customer is null)
            {
                return Results.NotFound();
            }
            if (!string.IsNullOrWhiteSpace(updatedCustomer.Name))
            {
                customer.Name = updatedCustomer.Name;
                customer.Email = updatedCustomer.Email;
                customer.Password = updatedCustomer.Password;
            }
            return Results.Ok(customer);
        });

        group.MapDelete("/{customerId}", (int customerId) =>
        {
            var customer = SalonData.Customers.FirstOrDefault(c => c.Id == customerId);
            if (customer is null)
            {
                return Results.NotFound();
            }
            SalonData.Customers.Remove(customer);
            return Results.NoContent();
        });

        //group.MapPost("/login", (string email, string password) =>
        ////TODO: make sure to use a json body - make sure the format matches with the frontend, but this is where we dictate the format.
        //{
        //    var customer = SalonData.Customers.FirstOrDefault(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && c.Password == password); 
        //    if (customer == null) 
        //    { 
        //        return Results.Unauthorized();
        //    } 
        //    return Results.Ok(customer); });



        app.MapPost("/api/customers/login", (Login login) =>
        {
            var customer = SalonData.Customers.FirstOrDefault(c =>
                c.Email.Equals(login.Email, StringComparison.OrdinalIgnoreCase) &&
                c.Password == login.Password);

            if (customer == null)
                return Results.Unauthorized();

            return Results.Ok(customer);
        });

    }
}
