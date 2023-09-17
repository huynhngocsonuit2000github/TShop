using Microsoft.EntityFrameworkCore;
using TShop.Domain.Entities;

namespace TShop.Domain.DataAccess;

public class TShopDbContext : DbContext
{ 
    public TShopDbContext(DbContextOptions<TShopDbContext> options):base(options)
    {

    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    { 
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, LastName = "Son", FirstName = "Huynh" },
            new User { Id = 2, LastName = "Vinh", FirstName = "Dang" },
            new User { Id = 3, LastName = "Nga", FirstName = "Le" }
        );  
    }


}
