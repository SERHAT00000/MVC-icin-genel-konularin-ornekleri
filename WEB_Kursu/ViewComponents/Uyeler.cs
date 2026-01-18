using Microsoft.AspNetCore.Mvc;
using WEB_Kursu.Models;

namespace WEB_Kursu.ViewComponents
{
    public class Uyeler : ViewComponent
    {   
        private readonly UyeContext _context;

        public Uyeler(UyeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            //List<string> uyeler = new List<string>()
            //{
            //    "Ayşe Yılmaz",
            //    "Mehmet Demir",
            //    "Fatma Kaya",
            //    "Ahmet Çelik",
            //    "Elif Şahin"
            //};
            return View(_context.Uyeler);

        }
    }
}