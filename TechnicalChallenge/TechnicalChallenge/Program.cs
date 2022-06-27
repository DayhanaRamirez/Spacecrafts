using Microsoft.EntityFrameworkCore;
using TechnicalChallenge.Data;
using TechnicalChallenge.Interfaces;
using TechnicalChallenge.Repositories;
using TechnicalChallenge.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TechnicalChallengeDbContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddTransient<IAstronautRepository, AstronautRepository>();
builder.Services.AddScoped<IAstronautServices, AstronautServices>();
builder.Services.AddTransient<ISpaceVehicleRepository, SpaceVehicleRepository>();
builder.Services.AddScoped<ISpaceVehicleServices, SpaceVehicleServices>();
builder.Services.AddTransient<IMethodsRepository, MethodsRepository>();
builder.Services.AddScoped<IMethodsServices, MethodsServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
