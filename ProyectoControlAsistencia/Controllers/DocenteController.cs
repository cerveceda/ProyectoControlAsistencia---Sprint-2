using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ENTIDAD;
using NEGOCIO;

namespace ProyectoControlAsistencia.Controllers
{
    public class DocenteController : Controller
    {
        // GET: Docente
        public ActionResult Index()
        {
            var docentes= DocentesCN.ListarDocentes();
            return View(docentes);
            
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Docente docente)
        {
            try
            {
                System.Threading.Thread.Sleep(2000);
                DocentesCN.Agregar(docente);
                return Json(new { ok = true, toRedirect = "Index" }, JsonRequestBehavior.AllowGet);
                
            }
            catch (Exception ex)
            {
                return Json(new { ok = false, msg= "Ocurrio un error al registrar al nuevo Docente" }, JsonRequestBehavior.AllowGet);
                //ModelState.AddModelError("", "Ocurrio un error al registrar al nuevo Docente");
                //return View(); 
            }
            
        }
    }
}