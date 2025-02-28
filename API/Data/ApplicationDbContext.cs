// Data/AppDbContext.cs
using GymManagement.API.Models;
using Microsoft.EntityFrameworkCore;

// Data/AppDbContext.cs
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Membership> Memberships { get; set; }
    public DbSet<Gym> Gyms { get; set; }
}
