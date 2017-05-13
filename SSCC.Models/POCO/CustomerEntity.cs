using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SSCC.Models.POCO
{
    /// <summary>
    /// Objeto cliente
    /// </summary>
    public partial class CustomerEntity //Características de la entidad cliente
    {

        public Guid CustomerID { get; set; }

        public string CustomerCode { get; set; }

        public string CustomerFirstName { get; set; }

        public string CustomerLastName { get; set; }

        public string CustomerCompanyName { get; set; }

        public Boolean CustomerType { get; set; }

        public string CustomerPhone { get; set; }

        public string CustomerAddress { get; set; }

        public Boolean CustomerIsActive { get; set; }

    }

    public partial class CustomerEntity //Variables de navegación
    {

        public virtual ICollection<SaleEntity> Sales { get; set; }

    }

    public class CustomerEntityMapping : EntityTypeConfiguration<CustomerEntity>
    {
        public CustomerEntityMapping()
        {
            ToTable("tblCustomers");

            HasKey(c=> c.CustomerID);

            Property(c => c.CustomerCode)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(20);

            Property(c => c.CustomerFirstName)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(c => c.CustomerLastName)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(c => c.CustomerCompanyName)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            Property(c => c.CustomerPhone)
                .HasColumnType("char")
                .HasMaxLength(9);

            Property(c => c.CustomerAddress)
                .HasColumnType("varchar")
                .HasMaxLength(256)
                .IsRequired();


        }


    }

}
