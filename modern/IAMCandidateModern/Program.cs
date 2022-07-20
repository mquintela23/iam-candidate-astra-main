using Business.Core.Repository;
using Business.Data.Repository;
using Business.Data.Repository.Models;
using Business.Interfaces.Repository;
using IAMCandidateModern.Infrastructure.FactoryClass;
using IAMCandidateModern.Interfaces.FactoryClass;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContextPool<MoDbContext>(options => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\aspnet-IAMCandidateTest.mdf"));

builder.Services.AddScoped<IUiModelFactory, UiModelFactory>();
builder.Services.AddScoped<IGenericRepository<Mineral>, MineralRepository>();
builder.Services.AddScoped<IGenericRepository<Animal>, AnimalRepository>();
builder.Services.AddScoped<IGenericRepository<Vegetable>, VegetableRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
