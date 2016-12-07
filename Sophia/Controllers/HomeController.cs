using Sophia.DAO;
using Sophia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sophia.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            RegistrosDAO dao = new RegistrosDAO();
            IList<Registro> registros = dao.Lista();

            ViewBag.Registros = registros;

            return View();
        }
    }
}