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
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Orders> Orders { get; set;}
        public DbSet<Shipments> Shipments { get; set; }
        public DbSet<Receivings> Receivings { get; set; }
        public DbSet<StockLevels> StockLevels { get; set; }
        public DbSet<Locations> Locations { get; set; }
    }
}
