namespace KazanMyo.HelloMvcSube2.Models
{
    public class Ogretmen
    {
        public string Tckimlik { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public override string ToString()
        {
            return $"Tc Kimlik:{this.Tckimlik} Ad:{this.Ad} Soyad:{this.Soyad}";
        }
    }
}
