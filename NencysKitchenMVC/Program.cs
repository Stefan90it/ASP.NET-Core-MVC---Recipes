using DependencyInjection;
using Microsoft.EntityFrameworkCore;
using NencysKitchenMVC.DbContexts;
using System.Reflection;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("NencyKitchenDbContextConnection") ?? throw new InvalidOperationException("Connection string 'NencyKitchenDbContextConnection' not found.");
builder.Services.MyServiceDependencies();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddDbContext<NencyKitchenDbContext>(options =>
            options.UseSqlServer("name=ConnectionStrings:NencyKitchenDbConn"));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<NencyKitchenDbContext>();

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
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints => {
    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{recipeId?}");
    endpoints.MapRazorPages();
});


app.Run();
