using System;
using YapGetir.Core.Entity;

namespace YapGetir.Model
{
    public class Siparis : BaseEntity
    {
        public int TarifID { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public int OdemeTipiID { get; set; }
        public string TeslimatAdresi { get; set; }
        public string SiparisDurumu { get; set; }
        public int RestoranID { get; set; }
        public int AsciID { get; set; }
        public int UyeID { get; set; }
        public decimal SiparisTutari { get; set; }

        //mapping
        public virtual Tarif Tarif { get; set; }
        public virtual Odeme Odeme { get; set; }
        public virtual Restoran Restoran { get; set; }
        public virtual Asci Asci { get; set; }
        public virtual UyeFormu UyeFormu { get; set; }

    }
}
