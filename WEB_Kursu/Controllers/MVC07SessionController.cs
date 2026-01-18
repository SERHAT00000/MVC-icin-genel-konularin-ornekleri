using Microsoft.AspNetCore.Mvc;

namespace WEB_Kursu.Controllers
{
    public class MVC07SessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
