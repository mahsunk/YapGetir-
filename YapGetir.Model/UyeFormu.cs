using System;
using System.Collections.Generic;
using YapGetir.Core.Entity;

namespace YapGetir.Model
{
    public class UyeFormu : BaseEntity
    {
        public UyeFormu()
        {
            Tedarikcis = new HashSet<Tedarikci>();
            Siparis = new HashSet<Siparis>();
            Yorums = new HashSet<Yorum>();
            Uruns = new HashSet<Urun>();

            Restorans = new HashSet<Restoran>();

        }
        public string UyeAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Semt { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int TipID { get; set; }

        //Mapping
        public virtual UyeTip UyeTip { get; set; }
        public virtual ICollection<Tedarikci> Tedarikcis { get; set; }
        public virtual ICollection<Siparis> Siparis { get; set; }
        public virtual ICollection<Yorum> Yorums { get; set; }
        public virtual ICollection<Urun> Uruns { get; set; }

        //eklenen navigation property
        public virtual ICollection<Restoran> Restorans { get; set; }
    }
}
