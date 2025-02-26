using DealAPI.Data;
using DealAPI.Services;
using DealAPI.Validation;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add CORS Policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});

// Add services to the container.
builder.Services.AddControllers();

// Use the new FluentValidation API to register validators
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters(); // Add this for client-side validation if needed

// Register FluentValidation validators from assembly
builder.Services.AddValidatorsFromAssemblyContaining<CreateDealDtoValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<UpdateDealDtoValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<HotelDtoValidator>();

// Register Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure DbContext to use Npgsql with connection string from app settings
builder.Services.AddDbContext<DealsDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DealConnectionString")));
builder.Services.AddScoped<IDealService, DealService>();


var app = builder.Build();

// Enable CORS before anything else
app.UseCors("AllowAll");

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty;  // Serve Swagger UI at root (localhost:5011/)
    });

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
