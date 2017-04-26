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
        public Product Save(Product Product)
        {
            //Validando datos
            this.Validation(Product);

            //Validando Código
            var pExist = this.Find(Product.ProductCode);
            if (pExist != null) // Si existe, entra
            {
                throw new Exception("Ya existe un producto con este Código");
            }

            using (var db = new ModelDb())
            {
                Product.ProductID = Guid.NewGuid();
                Product.ProductIsActive = true;

                //guardar producto
                db.Products.Add(Product);
                db.SaveChanges();
            }


            return Product;

        }

        public void Edit(Product Product)
        {
            //Validando datos
            this.Validation(Product);

            using (var db = new ModelDb())
            {
                //Se carga el producto
                var p = db.Products.Where(c => c.ProductID == Product.ProductID).FirstOrDefault();

                //Se verifica que existe
                if (p != null)
                {
                    //Validando Código
                    var pExist = this.Find(Product.ProductCode);
                    if (pExist != null) // Si existe, entra
                    {
                        if (pExist.ProductID != p.ProductID)
                        {
                            throw new Exception("Ya existe un producto con este Código");
                        }
                    }

                    //Se editan los datos
                    p.ProductCode = Product.ProductCode;
                    p.ProductName = Product.ProductName;
                    p.ProductPrice = Product.ProductPrice;
                    p.ProductDescription = Product.ProductDescription;
                    p.MarkID = Product.MarkID;
                    p.LineID = Product.LineID;

                    //Se prepara para la edición
                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;

                    //Se guardan los datos
                    db.SaveChanges();

                }
            }
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

        public List<Product> List(string ProductCode = "", string ProductName = "", decimal ProductPrice = 0, string ProductMark = "", string ProductLine = "", Boolean ProductState = true)
        {
            var db = new ModelDb();

            var productList = db.Products
                    .Where(c =>
                        c.ProductCode.Contains(ProductCode) && // Filtrando por código
                        c.ProductName.Contains(ProductName) && // Filtrando por nombre
                        c.ProductIsActive.Equals(ProductState) // Filtrando por estado
                    );

            //Filtrando por precio
            if (ProductPrice > 0)
            {
                productList = productList
                    .Where(c =>
                        c.ProductPrice == ProductPrice
                    );
            }

            //Filtrando por marca
            if (ProductMark != null)
            {
                if (ProductMark.Trim() != "")
                {
                    productList = productList
                        .Where(c =>
                            c.MarkID != null
                        )
                        .Where(c =>
                            c.Mark.MarkName.Contains(ProductMark)
                        );
                }
            }

            //Filtrando por linea
            if (ProductLine != null)
            {
                if (ProductLine.Trim() != "")
                {
                    productList = productList
                        .Where(c =>
                            c.LineID != null
                        )
                        .Where(c =>
                            c.Line.LineName.Contains(ProductLine)
                        );
                }
            }

            //Retornando la lista
            return productList.ToList();
        }

#endregion

        
    }

    public partial class RuleProduct // Métodos privados
    {
        private void Validation(Product Product)
        {
            if (Product == null)
            {
                throw new Exception("Ingresar los datos de Producto");
            }

            if (String.IsNullOrWhiteSpace(Product.ProductCode))
            {
                throw new Exception("Ingresar el Código");
            }

            if (String.IsNullOrWhiteSpace(Product.ProductName))
            {
                throw new Exception("Ingresar el Nombre");
            }

            if (Product.ProductPrice <= 0)
            {
                throw new Exception("Ingresar el Precio");
            }
        }
    }
}
