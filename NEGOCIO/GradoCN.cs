using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class GradoCN
    {
        public static void Agregar(Grado grdo) //GRado
        {
            obj.Agregar(grdo);
        }

        private static GradoDALC obj = new GradoDALC();
        public static List<Grado> ListarGrados()
        {
            return obj.ListarGrados();
        }

        public static Grado GetGrado(string id)  //mandamos el id o CodGado
        {
            return obj.GetGrado(id);
        }

        public static void Editar(Grado grdo)
        {
            obj.Editar(grdo);
        }
        public static void Eliminar(string id)
        {
            obj.Eliminar(id);
        }
    }
}