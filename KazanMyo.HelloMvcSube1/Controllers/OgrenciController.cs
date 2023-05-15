using KazanMyo.HelloMvcSube2.Models;
using Microsoft.AspNetCore.Mvc;

namespace KazanMyo.HelloMvcSube2.Controllers
{
    public class OgrenciController : Controller
    {
        public string Index()
        {
            return "Hello MVC!";
        }

        public ViewResult OgrenciBilgi(int id)
        {
            var ogr = new Ogrenci();
            if (id == 1)
            {
                ogr.Ad = "Ali";
                ogr.Soyad = "Veli";
                ogr.Numara = 123;
            }
            else if (id == 2)
            {
                ogr.Ad = "Ahmet";
                ogr.Soyad = "Mehmet";
                ogr.Numara = 456;
            }
            else
            {
                ogr = null;
            }
            ViewData["Ogrenci"] = ogr;
            ViewBag.Student = ogr;

            var ogretmen = new Ogretmen { Tckimlik = "123", Ad = "Cihan", Soyad = "Yetişken" };

            var info = new InfoDTO(ogr, ogretmen);

            return View(info);
        }
    }


}
