using Microsoft.AspNetCore.Mvc;
using WEB_Kursu.Models;

namespace WEB_Kursu.Controllers
{
    public class MVC05_Model_Validation : Controller
    {
        public IActionResult Index()
        {
            return View();
       
        
        }
        public IActionResult YeniUye()
        {
            return View();
       
        
        }
        [HttpPost]
        public IActionResult YeniUye(Uye uye)
        {
            return View();
       
        
        }
    }
        
        
    
}
