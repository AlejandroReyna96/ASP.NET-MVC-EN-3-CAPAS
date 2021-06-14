using ENTIDAD;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEB_PROYECTOS.Controllers
{
    public class DepartamentoController : Controller
    {
        // GET: Departamento esto es lo mismo que tener [HttpGet] (al no ponerlo, se entiende que es Get)
        public ActionResult Index()
        {
            var datos = DepartamentoCN.ListarDepartamentos();
            return View(datos);
        }

        [HttpGet] // Solicitar información del servidor
        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost] // Cuando envío información desde el cliente al servidor
        public ActionResult Crear(Departamento departamento)
        {
            try
            {
                DepartamentoCN.Agregar(departamento);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Ocurrió un error al Agregar un Departamento");
                return View(departamento);
            }   
        }

        public ActionResult Detail(int id)
        {
            var depertamento = DepartamentoCN.Detail(id);
            return View(depertamento);
        }

        public ActionResult Editar(int id)
        {
            var departamento = DepartamentoCN.Detail(id);
            return View(departamento);
        }
    }
}