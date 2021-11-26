using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;

namespace DATOS
{
    public class ApoderadosDALC
    {
        public void Agregar(Apoderado apoderado)
        {
            using (var db = new ProyectosContext())
            {
                db.TApoderado.Add(apoderado);
                db.SaveChanges();
            }
        }
        public List<Apoderado> ListarApoderados()
        {
            using (var db = new ProyectosContext())
            {
                return db.TApoderado.ToList();
            }
        }
    }
}
