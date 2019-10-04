using YapGetir.Core.Entity;

namespace YapGetir.Model
{
    public class Kampanya : BaseEntity
    {
        public string KampanyaAdi { get; set; }
        public short KampanyaSuresi { get; set; }
        public int UrunID { get; set; }

        public int RestoranID { get; set; }


        //mapping
        public virtual Urun Urun { get; set; }
        public virtual Restoran Restoran { get; set; }
    }
}
