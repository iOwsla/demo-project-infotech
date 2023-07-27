using AutoMapper;
using DemoProject.Data;
using DemoProject.Data.Entities;
using DemoProject.Data.Repositories;
using DemoProject.Infrastructure;
using DemoProject.Services.Cities;
using DemoProject.Services.Districts;
using DemoProject.Services.Requests;
using DemoProject.Services.Services;
using DemoProject.Services.Users;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace DemoProject;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();

        builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));

        var mapperConfig = new MapperConfiguration(mc => mc.AddProfile(new MappingProfile()));
        builder.Services.AddSingleton(mapperConfig.CreateMapper());

        builder.Services.AddScoped<IRepository<User>, UserRepository>();
        builder.Services.AddScoped<IRepository<UserDescription>, UserDescriptionRepository>();
        builder.Services.AddScoped<IRepository<UserRole>, UserRoleRepository>();
        builder.Services.AddScoped<IRepository<City>, CityRepository>();
        builder.Services.AddScoped<IRepository<District>, DistrictRepository>();
        builder.Services.AddScoped<IRepository<Request>, RequestRepository>();
        builder.Services.AddScoped<IRepository<Service>, ServiceRepository>();
        builder.Services.AddScoped<IRepository<ServiceCategory>, ServiceCategoryRepository>();

        builder.Services.AddScoped<IUserService, UserService>();
        builder.Services.AddScoped<IUserRoleService, UserRoleService>();
        builder.Services.AddScoped<ICityService, CityService>();
        builder.Services.AddScoped<IDistrictService, DistrictService>();
        builder.Services.AddScoped<IRequestService, RequestService>();
        builder.Services.AddScoped<IServiceService, ServiceService>();
        builder.Services.AddScoped<IServiceCategoryService, ServiceCategoryService>();

        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}