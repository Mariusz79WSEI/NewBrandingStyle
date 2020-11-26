using Microsoft.EntityFrameworkCore;
using NewBrandingStyle.Web.Entities;

namespace NewBrandingStyle.Web.Database
{
   public class ExchangesDbContext : DbContext
   {
      public ExchangesDbContext(DbContextOptions options) : base(options)
      {

      }

      public DbSet<ItemEntity> Items { get; set; }

      protected override void OnModelCreating(ModelBuilder builder)
      {

      }
   }
}
