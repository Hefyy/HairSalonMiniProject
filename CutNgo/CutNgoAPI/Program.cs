using Scalar.AspNetCore;
using CutNgoAPI.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

//app.UseHttpsRedirection();

app.UseCors("AllowAll");

//Endpoints
app.MapCustomerEndpoints();
app.MapEmployeeEndpoints();
app.MapBookingEndpoints();
app.MapTreatmentEndpoints();

app.Run();