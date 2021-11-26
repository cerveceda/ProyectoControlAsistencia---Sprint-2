using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class DocentesDALC      
    {
        public void Agregar(Docente docente)
        {
            using (var db = new ProyectosContext())
            {
                db.TDocente.Add(docente);
                db.SaveChanges();
            }
        }
        public List<Docente> ListarDocentes()
        {
            using (var db = new ProyectosContext())
            {
                return db.TDocente.ToList();
            }
        }
    }
}
