using Microsoft.AspNetCore.Mvc;

namespace WEB_Kursu.Controllers
{
    public class MVC10FileUploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(IFormFile dosya)
        {

            if (dosya != null)
            {
                var uzanti= Path.GetExtension(dosya.FileName);
                var Klasor = Directory.GetCurrentDirectory() + "~/wwwroot/Images/";
                var klasorvarmi =Directory.Exists(Klasor);
                TempData["Message"] = "klasor var mı:"+klasorvarmi;
                if (klasorvarmi == false)
                {
                    var sonuc= Directory.CreateDirectory(Klasor);
                    TempData["message"] += "---kalsor oluştu..." + sonuc;
                }
                if(uzanti==".jpg"|uzanti==".jpeg"| uzanti == ".png" | uzanti == ".gif")
                {
                    // yöntem bir
                    //var RandomFilename = Path.GetRandomFileName();
                    //var fileName= Path.ChangeExtension(RandomFilename,".jpg");
                    //var path =Path.Combine(Klasor,fileName);

                    //dosya.CopyTo( new FileStream(path, FileMode.Create));

                    // yöntem 2
                    //var dosyaAdi= Path.GetFileName(dosya.FileName);
                    //var yol = Path.Combine(Klasor, fileName);
                    //dosya.CopyTo(new FileStream(yol, FileMode.Create));

                    //yöntem 3
                    using var stream = new FileStream(Klasor+ dosya.FileName, FileMode.Create);
                    dosya.CopyTo(stream);
                    TempData["Resim"]= dosya.FileName;
                }
                else
                {
                    TempData["message"] = "Sadece .jpg, .jpeg, .png, .gif uzantılı dosyalar yüklenebilir"; 
                }

            }
            return View();
        }
        [HttpPost]
        public IActionResult ResimSil(string ResimYolu)
        {
            if (System.IO.File.Exists(ResimYolu))
            {
                System.IO.File.Delete(ResimYolu);
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}
