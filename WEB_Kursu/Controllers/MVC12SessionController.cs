using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Controller;
using WEB_Kursu.Extensions;
using WEB_Kursu.Models;

namespace WEB_Kursu.Controllers
{
    public class MVC12SessionController : Controller
    {
        private readonly UyeContext _context;
        public MVC12SessionController(UyeContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Sessionolustur(string KullaniciAdi, string Sifre)
        {
            var kullanici =_context.Uyeler.FirstOrDefault(u=> u.KullaniciAdi == KullaniciAdi&& u.Sifre== Sifre);
            if(kullanici != null) 
            {
                HttpContext.Session.SetString("deger", "admin");
                HttpContext.Session.SetString("userguid", Guid.NewGuid().ToString());
                HttpContext.Session.SetString("username", kullanici.KullaniciAdi);
                HttpContext.Session.SetInt32("kullaniciId", kullanici.Id);

                HttpContext.Session.SetJson( "kullanici", kullanici);
                TempData["mesaj"] = @"<div class='alert alert-succes' >Giriş başarılı!</div>";
                return RedirectToAction("SessionOku");
            }
            else
            
                TempData["mesaj"] = @"<div class='alert alert-danger' >Giriş başarısız!</div>";
            return RedirectToAction("Index");


        }
        public IActionResult SessionOku()
        {
            if(HttpContext.Session.GetString("username")== null|| HttpContext.Session.GetString("userguid")== null)
            {
                TempData["mesaj"] = @"<div class='alert alert-warning' >lütfen giriş yapınız</div>";
                return RedirectToAction("Index");
            }
            TempData["SessionBilgi"]= HttpContext.Session.GetString("deger");
            TempData["kullaniciAdi"] = HttpContext.Session.GetString("username");
            TempData["kullaniciguid"] = HttpContext.Session.GetString("userguid");

            return View();
        }
        public IActionResult SessionSil() 
        {
            HttpContext.Session.Remove("deger");
            HttpContext.Session.Remove("userguid");
            HttpContext.Session.Remove("username");
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

    }
    
    
}
