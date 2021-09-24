using SoluParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoluParcial.Controllers
{
    public class RegistrosController : Controller
    {
        // GET: Registros
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ClsValidacion validacion)
        {
            if (ModelState.IsValid)
            {
                return View("Registro");

            }
            else
            {
                return View("Index");
            }

        }
    }
}