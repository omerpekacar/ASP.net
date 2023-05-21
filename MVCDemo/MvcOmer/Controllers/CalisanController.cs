using MvcOmer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOmer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            CalisanContext calisanContext = new CalisanContext();
            List<Calisan> calisanlar = calisanContext.calisans.ToList();
            return View(calisanlar);



        }
        public ActionResult detay(int id)
        {
            CalisanContext calisanContext = new CalisanContext();
            Calisan calisan = calisanContext.calisans.Single(cal => cal.CalisanID == id);
            return View(calisan);
                
        }
    }
}
