using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SSCC.Models.POCO;
using SSCC.Models.Database;

namespace SSCC.Controllers
{
    public class RuleMark
    {
        public List<MarkEntity> List()
        {
            using (var db = new ModelDb())
            {
                return db.Marks
                    .AsParallel()
                    .OrderBy(c => c.MarkName)
                    .ToList();
            }
        }

        private void Validation(MarkEntity Mark)
        {
            //Si es null, se genera una exception por que no se han recibido los datos
            if (Mark == null)
            {
                throw new Exception("Error, no se ha enviado ningún dato acerca de la Marca.");
            }

            //Si la marca no tiene nombre se genera una exception
            if (String.IsNullOrWhiteSpace(Mark.MarkName))
            {
                throw new Exception("Ingresar el nombre de la Marca.");
            }

        }

        public MarkEntity Save(MarkEntity Mark)
        {
            this.Validation(Mark);

            using (var db = new ModelDb())
            {
                Mark.MarkID = Guid.NewGuid();

                db.Marks.Add(Mark);
                db.SaveChanges();

                return Mark;
            }
        }
    }
}
