using Microsoft.EntityFrameworkCore;

namespace warehouseManagement.Entities
{
    class warehouseDbContext: DbContext
    {
        public DbSet<Inventory> Inventory { get; set; } = null!;
        public DbSet<Supplier> Suppliers { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Shipment> Shipments { get; set; } = null!;
        public DbSet<Receiving> Receivings { get; set; } = null!;
        public DbSet<StockLevel> StockLevels { get; set; } = null!;
        public DbSet<Location> Locations { get; set; }
    }
}
