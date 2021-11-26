using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using DATOS;

namespace NEGOCIO
{
    public class GradoDocenteCN
    {
        private static GradoDocenteDALC obj = new GradoDocenteDALC();

        public static void Agregar(GradoDocente gradodocente)
        {
            obj.Agregar(gradodocente);
        }
        public static List<GradoDocente> ListarGradoDocentes()
        {

            return obj.ListarGradoDocentes();
        }
    }
}
