using System.Collections.Generic;
using YapGetir.Core.Entity;

namespace YapGetir.Model
{
    public class Tarif : BaseEntity
    {
        public Tarif()
        {
            Siparis = new HashSet<Siparis>();
            Yorums = new HashSet<Yorum>();
            Malzemes = new HashSet<Malzeme>();
            Paylasmas = new HashSet<Paylasma>();
        }
        public string TarifAdi { get; set; }
        public int KategoriID { get; set; }
        public string Aciklama { get; set; }
        public bool Favorimi { get; set; }
        public int PuanlamaID { get; set; }

        //mapping

        public virtual Kategori Kategori { get; set; }
        public virtual Puanlama Puanlama { get; set; }
        public virtual ICollection<Siparis> Siparis { get; set; }
        public virtual ICollection<Yorum> Yorums { get; set; }
        public virtual ICollection<Malzeme> Malzemes { get; set; }
        public virtual ICollection<Paylasma> Paylasmas { get; set; }
    }
}
