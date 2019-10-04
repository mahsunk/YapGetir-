using System.Collections.Generic;
using YapGetir.Core.Entity;

namespace YapGetir.Model
{
    public class Asci : BaseEntity
    {
        public Asci()
        {
            Siparis = new HashSet<Siparis>(); //yapıya daha hızlı erişmemizi sağlar.
            Yorums = new HashSet<Yorum>();
            Paylasmas = new HashSet<Paylasma>();
        }
        public string AsciAdi { get; set; }
        public int RestoranID { get; set; }
        public int PuanlamaID { get; set; }

        //mapping

        public virtual Restoran Restoran { get; set; }
        public virtual Puanlama Puanlama { get; set; }
        public virtual ICollection<Siparis> Siparis { get; set; }
        public virtual ICollection<Yorum> Yorums { get; set; }
        public virtual ICollection<Paylasma> Paylasmas { get; set; }

    }
}
