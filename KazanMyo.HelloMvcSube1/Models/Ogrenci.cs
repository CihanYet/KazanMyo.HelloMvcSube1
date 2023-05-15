using System;
using System.ComponentModel.DataAnnotations;

namespace KazanMyo.HelloMvcSube2.Models
{
    public class Ogrenci
    {
        public int Ogrenciid { get; set; }

        [Display(Name ="Adı")]
        public string Ad { get; set; }
        public string Soyad { get; set; }

        [Display(Name ="Numarası")]
        public int Numara { get; set; }

        public override string ToString()=> $"Ad:{this.Ad} Soyad:{this.Soyad} Numara:{this.Numara}";       
        

    }
}
