using KazanMyo.HelloMvcSube1.Models;
using KazanMyo.HelloMvcSube2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace KazanMyo.HelloMvcSube2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {   
            List<Ogrenci> ogrenciler;
            using (var ctx = new OkulDbContext())
            {
                ogrenciler = ctx.Ogrenciler.ToList();
            }
            return View(ogrenciler);
        }

        [HttpGet]
        public IActionResult AddStudent()
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

        public IActionResult UpdateStudent(int? id)
        {
            Ogrenci ogr = null;
            using (var ctx=new OkulDbContext())
            {
               ogr= ctx.Ogrenciler.Find(id);
            }
            return View(ogr);  
        }

        [HttpPost]
        public IActionResult UpdateStudent(Ogrenci ogr)
        {
            using (var ctx = new OkulDbContext())
            {
                ctx.Entry(ogr).State = EntityState.Modified;
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }

    static class Ext
    {
        public static int ToInt32(this object value)
        {
            return Convert.ToInt32(value);
        }
    }

    class Ev
    {
        public int Odasayisi { get; set; }
        public int Katno { get; set; }

    }

    class SatilikEv:Ev
    {
        public double Satisfiyat { get; set; }       
    }

    class KiralikEv:Ev
    {
        public double Kira { get; set; }
        public double Depozito { get; set; }
    }

    class Bankacilik : IBanka
    {
        public void Eft(string aliciiban, string gondericiiban, double tutar)
        {
            throw new NotImplementedException();
        }

        public void HesapAcma(string tckimlik, string ad, string soyad, string sube)
        {
            throw new NotImplementedException();
        }
    }

    interface IBanka
    {
        public void Eft(string aliciiban, string gondericiiban, double tutar);
        public void HesapAcma(string tckimlik, string ad, string soyad, string sube);
    }
}
//MVC Model Binding
