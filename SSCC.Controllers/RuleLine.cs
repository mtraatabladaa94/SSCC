using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SSCC.Models.POCO;
using SSCC.Models.Database;

namespace SSCC.Controllers
{
    public class RuleLine
    {
        public List<LineEntity> List()
        {
            using (var db = new ModelDb())
            {
                return db.Lines
                    .AsParallel()
                    .OrderBy(c => c.LineName)
                    .ToList();
            }
        }

        private void Validation(LineEntity Line)
        {

            //Si es null, se genera una exception por que no se han recibido los datos
            if (Line == null)
            {
                throw new Exception("Error, no se ha enviado ningún dato acerca de la Linea.");
            }

            //Si la marca no tiene nombre se genera una exception
            if (String.IsNullOrWhiteSpace(Line.LineName))
            {
                throw new Exception("Ingresar el nombre de la Linea.");
            }

        }

        public LineEntity Save(LineEntity Line)
        {
            this.Validation(Line);

            using (var db = new ModelDb())
            {
                Line.LineID = Guid.NewGuid();

                db.Lines.Add(Line);
                db.SaveChanges();

                return Line;
            }
        }
    }
}