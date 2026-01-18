using Microsoft.EntityFrameworkCore;
using WEB_Kursu.Models;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<UyeContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddControllersWithViews();

// Configure session with a reasonable timeout
builder.Services.AddSession(options => 
{
    options.IdleTimeout = TimeSpan.FromMinutes(20); // increased from 5 seconds
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
    options.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.Always;
});

builder.Services.AddControllersWithViews();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseSession();//session için gereklli midleware
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
