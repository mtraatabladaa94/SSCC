using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SSCC.Models.POCO;
using SSCC.Models.Database;

namespace SSCC.Controllers
{
    public partial class RuleProduct // Métodos públicos
    {
        /// <summary>
        /// Permite guardar un producto.
        /// </summary>
        /// <param name="Product">Objeto producto con sus datos</param>
        /// <returns>Si no hay ningún problema al guardar, este retorna el UNIQUEID generado al producto.</returns>
        public Guid Save(Product Product)
        {

            using (var db = new ModelDb())
            {
                Product.ProductID = Guid.NewGuid();                
                Product.ProductIsActive = true;

                //guardar producto
                db.Products.Add(Product);
                db.SaveChanges();
            }


            return Product.ProductID;

        }

        public void Edit(Product Product)
        {

        }

        public void Delete(Guid ProductID)
        {
            using (var db = new ModelDb())
            {
                var Product = this.Find(ProductID);
                if (Product != null)
                {

                    Product.ProductIsActive = false;

                    db.Entry(Product).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                }
            }
        }

#region Busquedas

        public Product Find(Guid ProductID)
        {
            using (var db = new ModelDb())
            {
                return db.Products.Where(c => c.ProductIsActive && c.ProductID == ProductID).FirstOrDefault();
            }
        }

        public Product Find(String ProductCode)
        {
            using (var db = new ModelDb())
            {
                return db.Products.Where(c => c.ProductIsActive && c.ProductCode == ProductCode).FirstOrDefault();
            }
        }

        public IEnumerable<Product> List()
        {
            return null;
        }

#endregion

        
    }

    public partial class RuleProduct // Métodos privados
    {

    }
}
