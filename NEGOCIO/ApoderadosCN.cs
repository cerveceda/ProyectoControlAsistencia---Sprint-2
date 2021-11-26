using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using DATOS;

namespace NEGOCIO
{
    public class ApoderadosCN
    {
        private static ApoderadosDALC obj = new ApoderadosDALC();

        public static void Agregar(Apoderado apoderado)
        {
            obj.Agregar(apoderado);
        }
        public static List<Apoderado> ListarApoderados()
        {

            return obj.ListarApoderados();
        }
    }
}
