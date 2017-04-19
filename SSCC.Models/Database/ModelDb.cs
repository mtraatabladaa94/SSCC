using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SSCC.Models.POCO;
using System.Data.Entity;

namespace SSCC.Models.Database
{
    /// <summary>
    /// Acceso a todos los recursos de la base de datos
    /// </summary>
    public partial class ModelDb : DbContext // Características del objeto base de datos
    {
        public ModelDb() : base("") { } // Establece la conexión de la base de datos

        public DbSet<Customer> Customers { get; set; }
        
        public DbSet<Line> Lines { get; set; }
        
        public DbSet<Mark> Marks { get; set; }
        
        public DbSet<Product> Products { get; set; }
        
        public DbSet<Receipt> Receipts { get; set; }
        
        public DbSet<ReceiptDetail> ReceiptsDetails { get; set; }
        
        public DbSet<ReceiptAdvance> ReceiptsAdvances { get; set; }
        
        public DbSet<Sale> Sales { get; set; }
        
        public DbSet<SaleDetail> SalesDetails { get; set; }
        
        public DbSet<User> Users { get; set; }

    }

    public partial class ModelDb // Configuración del modelo
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //Se elimina la pluralización del software
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            //Se llama al método sobrecargado de la superclase OnModelCreating
            base.OnModelCreating(modelBuilder);

        }
    }

}
