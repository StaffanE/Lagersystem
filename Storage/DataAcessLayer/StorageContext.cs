using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Storage.DataAcessLayer
{
    public class StorageContext : DbContext
    {
        public StorageContext() : base("DefaultConnection")     //  DefaultConnection blir namnet på databasen
        {
                
        }

        public DbSet<Models.Product> Products { get; set; }

    }
}