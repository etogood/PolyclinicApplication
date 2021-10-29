using Microsoft.EntityFrameworkCore;

namespace PolyclinicApplication.Data.Models
{
    public class AppDbContextFactory : IDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>();
            options.UseSqlServer(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PolyclinicDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            return new AppDbContext(options.Options);
        }
    }
}