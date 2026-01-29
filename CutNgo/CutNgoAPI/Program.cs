using Scalar.AspNetCore;
using CutNgoDomain.Services;
using CutNgoAPI.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

//Endpoints
app.MapCustomerEndpoints();
app.MapEmployeeEndpoints();
app.MapBookingEndpoints();

var service = new MockDataService();
var bookings = service.GetBookings();



app.Run();

