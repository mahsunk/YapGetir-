using System.Collections.Generic;
using YapGetir.Core.Entity;

namespace YapGetir.Model
{
    public class Urun : BaseEntity
    {
        public Urun()
        {
            Kampanyas = new HashSet<Kampanya>();
        }
        public string UrunAdi { get; set; }
        public int KategoriID { get; set; }
        public int TedarikciID { get; set; }
        public decimal Fiyati { get; set; }
        public int UyeID { get; set; }


        //mapping

        public virtual Kategori Kategori { get; set; }
        public virtual Tedarikci Tedarikci { get; set; }
        public virtual UyeFormu UyeFormu { get; set; }
        public virtual ICollection<Kampanya> Kampanyas { get; set; }
    }
}
