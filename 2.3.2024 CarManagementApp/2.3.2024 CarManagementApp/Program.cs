using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using _2._3._2024_CarManagementApp.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<_2_3_2024_CarManagementAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("_2_3_2024_CarManagementAppContext") ?? throw new InvalidOperationException("Connection string '_2_3_2024_CarManagementAppContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
