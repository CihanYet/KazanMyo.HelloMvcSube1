using KazanMyo.HelloMvcSube1.Models;
using KazanMyo.HelloMvcSube2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KazanMyo.HelloMvcSube2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Ogrenci> lst;
            using (var ctx = new OkulDbContext())
            {
                lst = ctx.Ogrenciler.ToList();
            }
            return View(lst);
        }

        [HttpGet]
        public ViewResult AddStudent()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddStudent(Ogrenci ogr)
        {
            using (var ctx = new OkulDbContext())
            {
                ctx.Ogrenciler.Add(ogr);
                int sonuc = ctx.SaveChanges();
                if (sonuc > 0)
                {
                    TempData["durum"] = true;
                }
            }
            return RedirectToAction("Index");
        }
    }
}
//MVC Model Binding
