using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSCC.Models.POCO
{
    /// <summary>
    /// Objeto Usuario
    /// </summary>
    public partial class User //Características del objeto Usuario
    {
        public Guid UserID { get; set; }

        public string UserFirstName { get; set; }

        public string UserLastName { get; set; }

        public string UserNic { get; set; }

        public string UserPassword { get; set; }

        public Boolean UserIsActive { get; set; }
    }

    public partial class User // Navegación del objeto Usuario
    {

    }

    public class UserMapping :EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            HasKey(c => c.UserID);

            Property(c => c.UserFirstName)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.UserLastName)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.UserNic)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.UserPassword)
                .HasColumnType("varchar")
                .HasMaxLength(null)
                .IsRequired();

        }
    }

    
}