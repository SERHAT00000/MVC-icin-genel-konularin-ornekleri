using Microsoft.AspNetCore.Mvc;
using WEB_Kursu.Models;

namespace WEB_Kursu.Controllers
{
    public class MVC06CRUDController : Controller
    {
        // 1. DbContext'i tutmak için 'readonly' bir alan (field) tanımlayın
        private  UyeContext db;

        // 2. CONSTRUCTOR (Yapıcı Metot) EKLEYİN
        //    Program.cs'de kayıtlı olan UyeContext servisini burada isteyin
        public MVC06CRUDController(UyeContext db)
        {
            this.db = db; // Gelen context'i _context değişkenine atayın
        }

        
        public IActionResult Index()
        {

            var uyeler = db.Uyeler.ToList();

            return View(uyeler);
        }
        public IActionResult Create()
        {

            

            return View();
        }
        [HttpPost]
        public IActionResult Create(Uye u)
        {
            if (ModelState.IsValid)
            {
                db.Uyeler.Add(u);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            

            return View();
        }
        public IActionResult Edit(int? id)

        {
            if (id == null)
            {
                return NotFound();
            }
            Uye uye = db.Uyeler.Find(id);
            if (uye == null)
            {
                return NotFound();
            }
            return View(uye);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Uye u)

        {
            if (ModelState.IsValid)
            {
                db.Entry(u).State= Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(u);
        }
        public IActionResult Details(int? id)

        {
            if (id == null)
            {
                return NotFound();
            }
            var uye = db.Uyeler.Find(id);
            if (uye == null)
            {
                return NotFound();
            }
            return View(uye);
        }
        public IActionResult Delete(int? id )

        {
            if (id == null)
            {
                return NotFound();
            }
            var uye = db.Uyeler.Find(id);
            if (uye == null)
            {
                return NotFound();
            }
            return View(uye);
        }
        [HttpPost]
        public IActionResult Delete(int? id, Uye uye2)

        {
            if (id == null)
            {
                return NotFound();
            }
            var uye = db.Uyeler.Find(id);
            if (uye == null)
            {
                return NotFound();
            }
            db.Entry(uye).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }


    }
}