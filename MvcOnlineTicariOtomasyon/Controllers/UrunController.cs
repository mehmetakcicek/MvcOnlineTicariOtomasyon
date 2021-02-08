using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyon.Models.Siniflar;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class UrunController : Controller
    {
        // 1. using bloğuna Modeldeki Sınıflar Klasörünü ekledim.
        // 2. Contex nesnesini new ile ms sql den bir instans bağlantı aldım.
        Context ctx = new Context();
        // GET: Urun
        public ActionResult Index()
        {
            var urunListGetir = ctx.Uruns.ToList();

            return View(urunListGetir);
        }
    }
}