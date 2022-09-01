using Microsoft.EntityFrameworkCore;

namespace LabAspMvc.Models 
{
    public class MobileContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public MobileContext(DbContextOptions<MobileContext> options) : base(options)
        {

        }
    }
}