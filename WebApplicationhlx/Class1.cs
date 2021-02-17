using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace WebApplicationhlx
{
    public class Product
    {
        [Key]
        public String Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

    }

    public class SelectedProduct
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int num { get; set; }
    }

    public class ShopRecord
    {
        [Key]
        public string Id { get; set; }

        public DateTime Time { get; set; }

        public double Sum { get; set; }
    }
   

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30")
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ApplicationDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<SelectedProduct> ShoppingList { get; set; }

        public DbSet<ShopRecord> ShopRecords { get; set; }
    }
}