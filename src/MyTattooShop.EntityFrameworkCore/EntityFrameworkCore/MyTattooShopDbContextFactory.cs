using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyTattooShop.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class MyTattooShopDbContextFactory : IDesignTimeDbContextFactory<MyTattooShopDbContext>
{
    public MyTattooShopDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        MyTattooShopEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<MyTattooShopDbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));
        
        return new MyTattooShopDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MyTattooShop.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false)
            .AddEnvironmentVariables();

        return builder.Build();
    }
}
