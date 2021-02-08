using MvcOnlineTicariOtomasyon.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori

        Context ctx = new Context();

        public ActionResult Index()
        {
            var degerler = ctx.Kategoris.ToList();

            return View(degerler);
        }

        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(Kategori ktg)
        {
            ctx.Kategoris.Add(ktg);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriSil(int id)
        {
            var SilinecekKategori = ctx.Kategoris.Find(id);

            ctx.Kategoris.Remove(SilinecekKategori);

            ctx.SaveChanges();

            return RedirectToAction("Index");
            
        }

        public  ActionResult KategoriGetir(int id)
        {
            var SecilenKategori = ctx.Kategoris.Find(id);

            return View("KategoriGetir", SecilenKategori);
        }

        public  ActionResult KategoriGuncelle(Kategori ktg)
        {
            var guncellenecekKtg = ctx.Kategoris.Find(ktg.KategoriId);

            guncellenecekKtg.KategoriAd = ktg.KategoriAd;

            ctx.SaveChanges();

            return RedirectToAction("Index");


        }

    }   
}