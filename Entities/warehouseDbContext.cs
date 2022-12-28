using Microsoft.EntityFrameworkCore;

namespace warehouseManagement.NewFolder
{
    class warehouseDbContext: DbContext
    {
        public warehouseDbContext(DbContextOptions<warehouseDbContext> options)
           : base(options)
        {
        }

        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set;}
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Receiving> Receivings { get; set; }
        public DbSet<StockLevel> StockLevels { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
