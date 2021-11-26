using System;
using ENTIDAD;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class GradoDocenteDALC
    {
        public void Agregar(GradoDocente gradodocente)
        {
            using (var db = new ProyectosContext())
            {

                db.TGradoTDocente.Add(gradodocente);
                db.SaveChanges();
            }
        }
        public List<GradoDocente> ListarGradoDocentes()
        {
            using (var db = new ProyectosContext())
            {
                return db.TGradoTDocente.ToList();
            }
        }
    }
}
