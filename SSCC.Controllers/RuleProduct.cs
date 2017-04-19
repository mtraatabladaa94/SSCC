using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SSCC.Models.POCO;
using SSCC.Models.Database;

namespace SSCC.Controllers
{
    public partial class RuleProduct
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
                

                //guardar producto
                db.Products.Add(Product);
                db.SaveChanges();
            }


            return Product.ProductID;

        }
    }
}
