using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class GradoDALC
    {
        public void Agregar(Grado grdo) //GRado
        {
            using (var db = new ProyectosContext())
            {
                db.TGrado.Add(grdo);
                db.SaveChanges();
            }
        }
        public List<Grado> ListarGrados()
        {
            using (var db = new ProyectosContext())
            {
                return db.TGrado.ToList(); //Tabla Base de Datos
            }
        }
        public Grado GetGrado(string id)  //mandamos el id o CodGado
        {
            using (var db = new ProyectosContext())
            {
                return db.TGrado.Find(id); //Tabla Base de Datos
                //return db.TGrado.Where(d => d.CodGrado == CodGrado).FirstOrDefault();
            }

        }

        public void Editar(Grado grdo)
        {
            using (var db = new ProyectosContext())
            {
                var d = db.TGrado.Find(grdo.CodGrado); //Consultamos en las tablas
                d.Nombre = grdo.Nombre;
                d.Seccion = grdo.Seccion;
                d.Nivel = grdo.Nivel;
                db.SaveChanges();
            }
        }
        public void Eliminar(string id)
        {
            using (var db = new ProyectosContext())
            {
                var d = db.TGrado.Find(id); //Consultamos en las tablas
                db.TGrado.Remove(d);
                db.SaveChanges();
            }
        }
    }
}