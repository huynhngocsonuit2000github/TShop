using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TShop.Domain.DataAccess;

public class TShopDbContextFactory : IDesignTimeDbContextFactory<TShopDbContext>
    {
        public TShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json")
                .Build();

            var connectionString = configuration.GetConnectionString("TShopDbContextConnection");

            var optionsBuilder = new DbContextOptionsBuilder<TShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new TShopDbContext(optionsBuilder.Options);
        }
    }