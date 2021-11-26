using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ENTIDAD;
using NEGOCIO;

namespace ProyectoControlAsistencia.Controllers
{
    public class GradoDocenteController : Controller
    {
        // GET: GradoDocente
        public ActionResult Index()
        {
            var gradodocentes = GradoDocenteCN.ListarGradoDocentes();
            return View(gradodocentes);

        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(GradoDocente gradodocente)
        {
            try
            {
                System.Threading.Thread.Sleep(2000);            
                GradoDocenteCN.Agregar(gradodocente);
                return Json(new { ok = true, toRedirect = "Index" }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                return Json(new { ok = false, msg = "Ocurrio un error al registrar al nuevo Grado Docente" }, JsonRequestBehavior.AllowGet);
                //ModelState.AddModelError("", "Ocurrio un error al registrar al nuevo Docente");
                //return View(); 
            }

        }
    }
}