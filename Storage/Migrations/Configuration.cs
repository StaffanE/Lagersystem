namespace Storage.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Storage.Models;


    internal sealed class Configuration : DbMigrationsConfiguration<Storage.DataAcessLayer.StorageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Storage.DataAcessLayer.StorageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
           
            context.Products.AddOrUpdate(
            p => p.Name,
            new Product { Id = 0001, Name = "Martin D28", Price = 28995m, Category = "Gitarr", Shelf = "A1", Count = 5, Description = "Modell: Dreadnaught, lock av Sitka spruce, Rygg och sidor av East Indian Rosewood" },
            new Product { Id = 0002, Name = "Avalon L325", Price = 29995m, Category = "Gitarr", Shelf = "A1", Count = 3, Description = "Modell: Jumbo, lock av Ceder, rygg och sidor av East Indian Rosewood" },
            new Product { Id = 0003, Name = "Lowden F23C", Price = 34995m, Category = "Gitarr", Shelf = "A1", Count = 2, Description = "Modell: MidJumbo, lock av Ceder, rygg och sidor av Claro Walnut" }
           
           );
            
        }
    }
}


