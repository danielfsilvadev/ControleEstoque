using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class GraficosController : Controller
    {
        // GET: Graficos
        public ActionResult PerdaMes()
        {
            return View();
        }

        public ActionResult EntradaSaidaMes()
        {
            return View();
        }
    }
}