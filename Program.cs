using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DogRazor.Data;
using DogRazor.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<DogRazorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DogRazorContext") ?? throw new InvalidOperationException("Connection string 'DogRazorContext' not found.")));

var app = builder.Build();

//Populate database
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
