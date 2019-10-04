using System.Collections.Generic;
using YapGetir.Core.Entity;

namespace YapGetir.Model
{
    public class Restoran : BaseEntity
    {
        public Restoran()
        {
            Ascis = new HashSet<Asci>();
            Tedarikcis = new HashSet<Tedarikci>();
            Siparis = new HashSet<Siparis>();
            Yorums = new HashSet<Yorum>();
            Kampanyas = new HashSet<Kampanya>();
            Paylasmas = new HashSet<Paylasma>();
        }
        public string RestoranAdi { get; set; }
        public int KategoriID { get; set; }
        public bool Favorimi { get; set; }
        public bool StoktakiMalzemeKontrol { get; set; }


        public int PuanlamaID { get; set; }

        public int UyeID { get; set; }


        //mapping
        public virtual Kategori Kategori { get; set; }
        public virtual Puanlama Puanlama { get; set; }

        //eklenen navigation property
        public virtual UyeFormu UyeFormu { get; set; }


        public virtual ICollection<Asci> Ascis { get; set; }
        public virtual ICollection<Tedarikci> Tedarikcis { get; set; }
        public virtual ICollection<Siparis> Siparis { get; set; }
        public virtual ICollection<Yorum> Yorums { get; set; }
        public virtual ICollection<Kampanya> Kampanyas { get; set; }
        public virtual ICollection<Paylasma> Paylasmas { get; set; }

    }
}
