using System;
using Domain;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Context;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

// Create the builder
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add DbContext with PostgreSQL
builder.Services.AddDbContext<GamePriceComparisonContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<DatabaseSeeder>(); // Add the seeder as a scoped service

// Build the app
var app = builder.Build();

// Check if the application should seed the database
if (args.Contains("populate-database"))
{
    await PopulateDatabaseAsync(app.Services);
    return;
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

// Method to seed the database
async Task PopulateDatabaseAsync(IServiceProvider services)
{
    using var scope = services.CreateScope();
    var seeder = scope.ServiceProvider.GetRequiredService<DatabaseSeeder>();
    await seeder.SeedAsync();
}

// Seeder class for database seeding
public class DatabaseSeeder
{
    private readonly GamePriceComparisonContext _context;

    public DatabaseSeeder(GamePriceComparisonContext context)
    {
        _context = context;
    }

    public async Task SeedAsync()
    {
        // Ensure database is created
        await _context.Database.MigrateAsync();

        // Example: Add initial data if not already present
        if (!await _context.Games.AnyAsync())
        {
            _context.Games.Add(new Game { Title = "Sample Game" });
            await _context.SaveChangesAsync();
        }

        // Add more seeding logic as needed
    }
}
