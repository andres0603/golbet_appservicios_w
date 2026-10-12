using Golbet.Repositories.Data;
using GolBet.Repositories.Data;
using GolBet.Repositories.Implementations;
using GolBet.Repositories.Interfaces;
using GolBet.Services.Implementations;
using GolBet.Services.Interfaces;
using GolBet.Services.Mapping;
<<<<<<< HEAD
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using System.Globalization;



var culture = new CultureInfo("es-CO");

CultureInfo.DefaultThreadCurrentCulture = culture;

CultureInfo.DefaultThreadCurrentUICulture = culture;



var builder = WebApplication.CreateBuilder(args);

// ... 

=======
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

>>>>>>> 53a65f7dd7c72ed2cb967c3babcb4e01c8c93833
builder.Services.AddControllersWithViews();

//Este es el nuevo código  

builder.Services.AddDbContext<AppDbContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

  

// Open generic registration: one line, a repository for every entity 

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));



// Specific repositories 

builder.Services.AddScoped<IMatchRepository, MatchRepository>();



// AutoMapper: scans the assembly containing MappingProfile for all profiles 

builder.Services.AddAutoMapper(typeof(MappingProfile));



// Business services 

builder.Services.AddScoped<IMatchService, MatchService>();
<<<<<<< HEAD
builder.Services.AddScoped<ITeamService, TeamService>();
=======
>>>>>>> 53a65f7dd7c72ed2cb967c3babcb4e01c8c93833
var app = builder.Build();
// Seed the database on startup 

using (var scope = app.Services.CreateScope())

{

    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    await DbSeeder.SeedAsync(context);

}

<<<<<<< HEAD

=======
>>>>>>> 53a65f7dd7c72ed2cb967c3babcb4e01c8c93833
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
