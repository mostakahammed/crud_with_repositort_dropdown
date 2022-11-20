using Microsoft.EntityFrameworkCore;
using Practice.DataAccess.Context;
using Practice.Service.Implementation;
using Practice.Service.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddMvc();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("db")));
builder.Services.AddTransient<IApplicantBLR, ApplicantBLR>();
builder.Services.AddTransient<ICountryBLR, CountryBLR>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Applicants}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
