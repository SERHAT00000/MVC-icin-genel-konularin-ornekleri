using Microsoft.AspNetCore.Mvc;
using WEB_Kursu.Models;

namespace WEB_Kursu.Controllers
{
    public class MVC04_Model_Binding_Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult KullaniciDetay()
        {
            Kullanici kullanici = new Kullanici()
            {
                Id = 1,
                Ad = "Adem",
                Soyad = "Keser",
                Email = "Akeser@gmail.com",
                KullaniciAdi = "A_keser",
                Sifre = "Ak_1",
            };
            return View(kullanici);
        }
        [HttpPost]
        public IActionResult KullaniciDetay(Kullanici kullanici)
        {
            return View(kullanici);
        }
        public IActionResult AdresDetay(Adres adres)
        {
            
            return View(adres);

        }
        public IActionResult KullaniciAdresDetay()
        {
            Kullanici kullanici = new Kullanici()
            {
                Id = 1,
                Ad = "Adem",
                Soyad = "Keser",
                Email = "Akeser@gmail.com",
                KullaniciAdi = "A_keser",
                Sifre = "Ak_1",
            };
            var model = new UyeSayfasiViewModel() 
            {
                Kullanici = kullanici,
                Adres= new Adres
                {
                    Sehir="Bursa",
                    Ilce="Orhangazi",
                    AcikAdres="orhanEli"
                }
            };

            return View(model);

        }
    }
}
