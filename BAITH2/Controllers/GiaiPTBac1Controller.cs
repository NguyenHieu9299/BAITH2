using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAITH2.Models;
namespace BAITH2.Controllers
{
    public class GiaiPTBac1Controller : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        // GET: GiaiPTBac1
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GiaiPTB1(string SoA, string SoB)
        {
            double a = double.Parse(SoA);
            double b = double.Parse(SoB);
            double x = gpt.GiaiPTBac1(a, b);
            ViewBag.NghiemPT = x;
            return View();
        }

    }
}