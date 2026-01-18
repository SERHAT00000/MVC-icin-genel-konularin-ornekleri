using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WEB_Kursu.Models;

namespace WEB_Kursu.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // Data Transfer
        public IActionResult Index(string ürünAra)
        {
            // 1- ViewBag
            ViewBag.UrunKategorisi = "Bilgisayar";

            var UrunListesi = new List<Urun> { 
             new Urun{Id=1, Adi="Tablet", Resim="Tablet.png",StokAdedi=301,UrunKategori="Teknolojik"},
             new Urun{Id=2, Adi="Bilgisayar", Resim="Bilgisayar.png",StokAdedi=30,UrunKategori="Teknolojik"},
             new Urun{Id=3, Adi="Olta", Resim="Olta.png",StokAdedi=3010,UrunKategori="Av malzemesi"},
            };
            // 2- ViewData
            ViewData["Urunler"]= UrunListesi;

            //3- TempData
            TempData["Urun bilgi"]= "Toplam " +UrunListesi.Count+ "ürün bulundu";

            ViewBag.AramaGirdisi = ürünAra;

            return View();
        }
        [HttpPost]
        public IActionResult Index(string txtUrunAdi,string ddlkategori,string rbOnay, bool cbOnay, IFormCollection formcollection)
        {
            var UrunListesi = new List<Urun> {
             new Urun{Id=1, Adi="Tablet", Resim="Tablet.png",StokAdedi=301,UrunKategori="Teknolojik"},
             new Urun{Id=2, Adi="Bilgisayar", Resim="Bilgisayar.png",StokAdedi=30,UrunKategori="Teknolojik"},
             new Urun{Id=3, Adi="Olta", Resim="Olta.png",StokAdedi=3010,UrunKategori="Av malzemesi"},
            };
           
            ViewData["Urunler"] = UrunListesi;

            ViewBag.Baslik1 = "1. yöntem Parametreyle veri yakalama";
            ViewBag.Mesaj1 = "txturunAdi: " +  txtUrunAdi;
            ViewBag.Mesaj2 = "ddlkategori: " + ddlkategori;
            ViewBag.Mesaj3 = "rbOnay: " + rbOnay;
            ViewBag.Mesaj3 += "cbOnay: " + cbOnay;

            ViewBag.Baslik2 = "2. yöntem FormCollection ile veri yakalama";
            ViewBag.Mesaj5 = "txturunAdi: " + formcollection["txtUrunAdi"];
            ViewBag.Mesaj6 = "ddlkategori: " + formcollection["ddlkategori"];
            ViewBag.Mesaj7 = "rbOnay: " + formcollection["rbOnay"];
            ViewBag.Mesaj7 += "cbOnay: " + formcollection["cbOnay"];


            ViewBag.Baslik3 = "3. yöntem request Form ile veri yakalama";
            ViewBag.Mesaj8 = "txturunAdi: " + Request.Form["txtUrunAdi"];
            ViewBag.Mesaj9 = "ddlkategori: " + Request.Form["ddlkategori"];
            ViewBag.Mesaj10 = "rbOnay: " + Request.Form["rbOnay"];
            ViewBag.Mesaj10 += "cbOnay: " + Request.Form["cbOnay"];
            ViewBag.Mesaj10 += "ddlkategori: " + Request.Form["ddlkategori"];
            return View();
        }



    }
}
