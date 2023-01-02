using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using warehouseManagement.Entities;

namespace warehouseManagement.Entities
{
    public class warehouseDbContext: DbContext
    {
      //  public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddDebug(); });
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=warehouseManagement;Integrated Security=True;");
        }
        public DbSet<Inventory> Inventory { get; set; } = null!;
        public DbSet<Supplier> Suppliers { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Shipment> Shipments { get; set; } = null!;
        public DbSet<Receiving> Receivings { get; set; } = null!;
        public DbSet<StockLevel> StockLevels { get; set; } = null!;
        public DbSet<Location> Locations { get; set; } = null!;



    }
}
