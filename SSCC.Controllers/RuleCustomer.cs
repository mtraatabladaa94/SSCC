using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SSCC.Models.POCO;
using SSCC.Models.Database;

namespace SSCC.Controllers
{
    public class RuleCustomer
    {
        /// <summary>
        /// Permite guardar un cliente.
        /// </summary>
        /// <param name="Customer">Objeto cliente con sus datos</param>
        /// <returns>Si no hay ningún problema al guardar, este retorna el UNIQUEID generado al cliente.</returns>
        

        public Guid Save(CustomerEntity Customer)
        {
            using (var db = new ModelDb())
            {
                Customer.CustomerID = Guid.NewGuid();
                Customer.CustomerIsActive = true;

                //Guardamos el cliente
                db.Customers.Add(Customer);
                db.SaveChanges();
                              
            }
            return Customer.CustomerID;
        }

        #region Busquedas

        public CustomerEntity Find(Guid CustomerID)
        {
            using (var db = new ModelDb())
            {
                return db.Customers.Where(c => c.CustomerIsActive && c.CustomerID == CustomerID).FirstOrDefault();
            }
        }

        public CustomerEntity Find(String CustomerCode)
        {
            using (var db = new ModelDb())
            {
                return db.Customers.Where(c => c.CustomerIsActive && c.CustomerCode == CustomerCode).FirstOrDefault();
            }
        }

        public IEnumerable<CustomerEntity> List()
        {
            return null;
        }

        #endregion



        public void Delete(Guid CustomerID)
        {
            using (var db = new ModelDb())
            {
                var Customer = this.Find(CustomerID);
                if (Customer != null)
                {

                    Customer.CustomerIsActive = false;

                    db.Entry(Customer).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                }
            }

        }
    }
}
