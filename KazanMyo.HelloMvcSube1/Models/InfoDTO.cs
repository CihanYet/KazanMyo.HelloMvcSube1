namespace KazanMyo.HelloMvcSube2.Models
{
    public class InfoDTO
    {
        public InfoDTO()
        {

        }

        public InfoDTO(Ogrenci ogrenci, Ogretmen ogretmen)
        {
            this.Ogrenci = ogrenci;
            this.Ogretmen = ogretmen;
        }
        public Ogretmen Ogretmen { get; set; }
        public Ogrenci Ogrenci { get; set; }

    }
}
//Data Transfer Object