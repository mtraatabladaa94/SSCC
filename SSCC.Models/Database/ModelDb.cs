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
        public ModelDb() : base(@"Data Source = .\UNANFAREMCH; Initial Catalog = SsccDB; Integrated Security = True;") { } // Establece la conexión de la base de datos

        public DbSet<CustomerEntity> Customers { get; set; }
        
        public DbSet<LineEntity> Lines { get; set; }
        
        public DbSet<MarkEntity> Marks { get; set; }

        
        public DbSet<ProductEntity> Products { get; set; }
        
        public DbSet<ReceiptEntity> Receipts { get; set; }
        
        public DbSet<ReceiptDetailEntity> ReceiptsDetails { get; set; }
        
        public DbSet<ReceiptAdvanceEntity> ReceiptsAdvances { get; set; }
        
        public DbSet<SaleEntity> Sales { get; set; }
        
        public DbSet<SaleDetailEntity> SalesDetails { get; set; }
        
        //public DbSet<User> Users { get; set; }

    }

    public partial class ModelDb // Configuración del modelo
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //Se elimina la pluralización del software
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            //Añadiendo configuración de entidades
            modelBuilder.Configurations.Add(new CustomerEntityMapping());
            modelBuilder.Configurations.Add(new LineMappingEntity());
            modelBuilder.Configurations.Add(new MarkEntityMapping());
            modelBuilder.Configurations.Add(new ProductEntityMapping());
            modelBuilder.Configurations.Add(new ReceiptEntityMapping());
            modelBuilder.Configurations.Add(new ReceiptAdvanceEntityMapping());
            modelBuilder.Configurations.Add(new ReceiptDetailEntityMapping());
            modelBuilder.Configurations.Add(new SaleEntityMapping());
            modelBuilder.Configurations.Add(new SaleDetailEntityMapping());

            //Se llama al método sobrecargado de la superclase OnModelCreating
            base.OnModelCreating(modelBuilder);

        }
    }

}
