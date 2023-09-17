using Microsoft.EntityFrameworkCore;
using TShop.Domain.Entities;

namespace TShop.Domain.DataAccess;

public class TShopDbContext : DbContext
{ 
    public TShopDbContext(DbContextOptions<TShopDbContext> options):base(options)
    {

    }

    public DbSet<User> Users { get; set; }
}
