using Microsoft.AspNetCore.Mvc;
using WEB_Kursu.Models;

namespace WEB_Kursu.Controllers
{
    public class MVC08PartialController : Controller
    {

        private UyeContext db;

        // 2. CONSTRUCTOR (Yapıcı Metot) EKLEYİN
        //    Program.cs'de kayıtlı olan UyeContext servisini burada isteyin
        public MVC08PartialController(UyeContext db)
        {
            this.db = db; // Gelen context'i _context değişkenine atayın
        }
        public IActionResult Index()
        {
            var uyeler = db.Uyeler.ToList();

            return View(uyeler);
        }
    }
}
