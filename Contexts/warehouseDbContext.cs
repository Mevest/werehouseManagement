using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections;
using System.Linq;
using System.Security.Cryptography;
using warehouseManagement.Entities;
using System.Collections.Generic;

namespace warehouseManagement.Entities
{
    public class warehouseDbContext: DbContext
    {
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddDebug(); });
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(MyLoggerFactory)
            .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=warehouseManagement;Integrated Security=True;");
        }
        public DbSet<Inventory> Inventory { get; set; } = null!;
        public DbSet<Supplier> Supplier { get; set; } = null!;
        public DbSet<Customer> Customer { get; set; } = null!;
        public DbSet<Order> Order { get; set; } = null!;
        public DbSet<Shipment> Shipment { get; set; } = null!;
        public DbSet<Receiving> Receiving { get; set; } = null!;
        public DbSet<StockLevel> StockLevel { get; set; } = null!;
        public DbSet<Location> Location { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }


        //----------INVENTORY-----------
        public virtual ICollection<Inventory> SearchInventory(string searchItemName)
        {
            var result = Inventory
                .Where(x => x.ItemName.Contains(searchItemName))
                .ToList();
            return result;
        }

        public virtual ICollection<Inventory> SearchDescription(string searchDescription)
        {
            var result = Inventory
                .Where(x => x.Description.Contains(searchDescription))
                .ToList();
            return result;
        }

        public virtual ICollection<Inventory> Quantity(int Quantity)
        {
            var result = Inventory
                .Where(x => x.Quantity.Equals(Quantity))
                .ToList();
            return result;
        }

        public virtual ICollection<Inventory> InventoryID(int ID)
        {
            var result = Inventory.Where(x => x.ID.Equals(ID))
                .ToList();
            return result;
        }
        // || Shipment || Customers || Orders 
        //----------INVENTORY-----------
        public virtual ICollection<StockLevel> StockID(int ID)
        {
            var result = StockLevel
                .Where(x => x.ID.Equals(ID))
                .ToList();
            return result;
        }

        public virtual ICollection<Location> LocationID(int ID)
        {
            var result = Location
                .Where(x => x.ID.Equals(ID))
                .ToList();
            return result;
        }

        public virtual ICollection<Location> Aisle(int Aisle)
        {
            var result = Location
                .Where(x => x.Aisle.Equals(Aisle))
                .ToList();
            return result;
        }


    }
}
