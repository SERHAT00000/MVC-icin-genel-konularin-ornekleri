using Microsoft.AspNetCore.Mvc;

namespace WEB_Kursu.Controllers
{
    public class MVC16HttpContextController : Controller
    {
        public IActionResult Index()
        {
            var mesaj = "Routedata Controller : " + RouteData.Values["Controller"];
            mesaj+= " <br/> RouteData action : " + RouteData.Values["Action"];
            mesaj+= " <br/> RouteData Id : " + RouteData.Values["id"];
            mesaj+= " <br/> QueryString kelime : " + HttpContext.Request.Query["kelime"];
            TempData["mesaj"] = mesaj;
            return View();
        }
    }
}
