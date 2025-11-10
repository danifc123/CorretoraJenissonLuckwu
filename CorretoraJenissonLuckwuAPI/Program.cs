using Microsoft.EntityFrameworkCore;
using CorretoraJenissonLuckwuAPI.EFModel.Configurations;
using CorretoraJenissonLuckwuAPI.Repository;
using CorretoraJenissonLuckwuAPI.Services;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRouting(o =>
{
    o.LowercaseUrls = true;
    o.LowercaseQueryStrings = true;
});

builder.Services.AddControllers();
builder.Services.AddDbContext<CorretoraJenissonLuckwuDb>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<AdministradorRepository>();
builder.Services.AddScoped<AdministradorService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
