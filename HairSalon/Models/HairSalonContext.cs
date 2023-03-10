using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    public DbSet<Item> Stylists { get; set; }
    public DbSet<Category> Clients { get; set; }
    public HairSalonContext(DbContextOptions options) : base(options) { }
  }
}