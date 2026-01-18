using Microsoft.AspNetCore.Mvc;
using WEB_Kursu.Models;

namespace WEB_Kursu.Controllers
{
    public class MVC18ViewComponentsController : Controller
    {
        private readonly UyeContext _context;

        public MVC18ViewComponentsController(UyeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();//_context.Uyeler
        }
    }
}
