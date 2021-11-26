using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using DATOS;

namespace NEGOCIO
{
    public class DocentesCN
    {

        private static DocentesDALC obj = new DocentesDALC();

        public static void Agregar(Docente docente)
        {
            obj.Agregar(docente);
        }
        public static List<Docente> ListarDocentes()
        {

            return obj.ListarDocentes();
        }
    }

    
}
