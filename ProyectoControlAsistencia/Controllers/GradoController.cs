using ENTIDAD;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProyectoControlAsistencia.Controllers
{
    public class GradoController : Controller
    {
        // GET: Grado
        public ActionResult Index()
        {
            var grdos = GradoCN.ListarGrados();
            return View(grdos);
        }

        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Grado grdo)
        {
        
            try
            {
                System.Threading.Thread.Sleep(2000);
                GradoCN.Agregar(grdo);
                return Json(new { ok = true, toRedirect = "Index" }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                return Json(new { ok = false, msg = "Ocurrio un error al Registrar un nuevo  Grado y Seccion" }, JsonRequestBehavior.AllowGet);
                //ModelState.AddModelError("", "Ocurrio un error al registrar al nuevo Docente");
                //return View(); 
            }


        }

        public ActionResult GetGrado(string id)
        {
            var grdo = GradoCN.GetGrado(id);
            return View(grdo);
        }

        public ActionResult Editar(string id)
        {
            var grdo = GradoCN.GetGrado(id);
            return View(grdo);
        }

        [HttpPost]
        public ActionResult Editar(Grado grdo)
        {
            try
            {
                if ( grdo.Nombre == null || grdo.Seccion == null || grdo.Nivel == null)
                {
                    ModelState.AddModelError("", "Debe llenar todos los datos");
                }

                GradoCN.Editar(grdo);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrio un error al Actualizar el Grado y Seccion");
                return View(grdo);
            }

        }

        [HttpGet]
        public ActionResult Eliminar(string id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);


            var grdo = GradoCN.GetGrado(id);
            return View(grdo);
        }

        [HttpPost]
        public ActionResult Eliminar(string id, string confirmButton)
        {
            try
            {
                GradoCN.Eliminar(id);
                //return Json(new { ok = true, toRedirect = "Index" }, JsonRequestBehavior.AllowGet);
                return RedirectToAction("Index");
               
            }
            catch (Exception ex)
            {
                //return Json(new { ok = false, msg = "Ocurrio un ERROR al eliminar" }, JsonRequestBehavior.AllowGet);
                ModelState.AddModelError("", "Ocurrio un error al eliminar el Grado y Seccion");
                return View();
            }
        }

    }

}