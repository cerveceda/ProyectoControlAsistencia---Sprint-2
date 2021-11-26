using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ENTIDAD;
using NEGOCIO;

namespace ProyectoControlAsistencia.Controllers
{
    public class ApoderadoController : Controller
    {
        // GET: Apoderado
        public ActionResult Index()
        {
            var apoderados = ApoderadosCN.ListarApoderados();
            return View(apoderados);

        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Apoderado apoderado)
        {
            try
            {
                System.Threading.Thread.Sleep(2000);
                ApoderadosCN.Agregar(apoderado);
                return Json(new { ok = true, toRedirect = "Index" }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                return Json(new { ok = false, msg = "Ocurrio un error al registrar al nuevo Apoderado" }, JsonRequestBehavior.AllowGet);
                //ModelState.AddModelError("", "Ocurrio un error al registrar al nuevo Docente");
                //return View(); 
            }

        }
    }
}