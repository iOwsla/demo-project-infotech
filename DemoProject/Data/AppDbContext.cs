using DemoProject.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<UserDescription> UserDescriptions { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<ServiceCategory> ServiceCategories { get; set; }
    public DbSet<Request> Requests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("Users");

        modelBuilder.Entity<UserRole>().ToTable("UserRoles");

        modelBuilder.Entity<UserDescription>().ToTable("UserDescriptions");

        modelBuilder.Entity<City>().ToTable("Cities");

        modelBuilder.Entity<District>().ToTable("Districts");

        modelBuilder.Entity<Service>().ToTable("Services");

        modelBuilder.Entity<ServiceCategory>().ToTable("ServiceCategories");

        modelBuilder.Entity<Request>().ToTable("Requests");

        modelBuilder.Entity<User>()
            .HasOne(u => u.Role)
            .WithMany(r => r.Users)
            .HasForeignKey(u => u.RoleId);

        modelBuilder.Entity<User>()
            .HasOne(u => u.Description)
            .WithOne(d => d.User)
            .HasForeignKey<UserDescription>(d => d.Id);

        modelBuilder.Entity<User>()
            .HasMany(u => u.Services)
            .WithOne(s => s.Provider)
            .HasForeignKey(s => s.ProviderId);

        modelBuilder.Entity<User>()
            .HasMany(u => u.Requests)
            .WithOne(r => r.Customer)
            .HasForeignKey(r => r.CustomerId);

        modelBuilder.Entity<UserDescription>()
            .HasOne(d => d.City)
            .WithMany(c => c.UserDescriptions)
            .HasForeignKey(d => d.CityId);

        modelBuilder.Entity<UserDescription>()
            .HasOne(d => d.District)
            .WithMany(d => d.UserDescriptions)
            .HasForeignKey(d => d.DistrictId);

        modelBuilder.Entity<City>()
            .HasMany(c => c.Districts)
            .WithOne(d => d.City)
            .HasForeignKey(d => d.CityId);

        modelBuilder.Entity<City>()
            .HasMany(c => c.Services)
            .WithOne(s => s.City)
            .HasForeignKey(s => s.CityId);

        modelBuilder.Entity<District>()
            .HasMany(d => d.Services)
            .WithOne(s => s.District)
            .HasForeignKey(s => s.DistrictId);

        modelBuilder.Entity<Service>()
            .HasOne(s => s.Category)
            .WithMany(c => c.Services)
            .HasForeignKey(s => s.CategoryId);

        modelBuilder.Entity<Service>()
            .HasMany(s => s.Requests)
            .WithOne(r => r.Service)
            .HasForeignKey(r => r.ServiceId);
    }
}