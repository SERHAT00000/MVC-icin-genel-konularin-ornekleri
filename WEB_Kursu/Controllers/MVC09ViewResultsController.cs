using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace WEB_Kursu.Controllers
{
    public class MVC09ViewResultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FarkliVewDondur()
        {
            return View();
        }
        public IActionResult Yonlendir()
        {
            //return Redirect("/");
            //return Redirect("/Home/Index?kelime=Bilgisayar");
            return Redirect("https://www.instagram.com/");
        }
        public IActionResult ActionaYonlendir()
        {
            //return RedirectToAction("Index");
            //return RedirectToAction("Yonlendir");
            // alttaki gbi bir yönlendirme verildiğinde home ifadesini kendi controller i olarak görür
            return RedirectToAction("Index","Home");
        }
        public RedirectToRouteResult RouteYonlendir()
        {
            
            return RedirectToRoute("Default",new {controller="Home", action="Index" ,id= 10});
        }
        public PartialViewResult KategorileriGetirPartial()
        {
            return PartialView("_KategorilerPartial");
        }
    }
}
