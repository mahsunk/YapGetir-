using System.Collections.Generic;
using YapGetir.Core.Entity;

namespace YapGetir.Model
{
    public class Tedarikci : BaseEntity
    {
        public Tedarikci()
        {
            Uruns = new HashSet<Urun>();
        }

        public string TedarikciFirmaAdi { get; set; }
        public string Adres { get; set; }
        public string Şehir { get; set; }
        public string TelefonNO { get; set; }
        public string Ulke { get; set; }
        public int UyeID { get; set; }
        public int RestoranID { get; set; }

        //mapping
        public virtual UyeFormu UyeFormu { get; set; }
        public virtual Restoran Restoran { get; set; }
        public virtual ICollection<Urun> Uruns { get; set; }


    }
}
