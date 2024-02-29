using RepositoryDesingScript.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RepositoryDesingScript.Models;
using RepositoryDesingScript.Repository;
using RepositoryDesingScript.Interface;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<UserRepository>();
//builder.Services.AddDbContext<Context>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("DataConnection")));
builder.Services.AddDbContext<Context>(options =>
		options.UseSqlServer(builder.Configuration.GetConnectionString("DataConnection")));
builder.Services.AddTransient<IUserInterface, UserRepository>();
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
