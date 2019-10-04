using System.Collections.Generic;
using YapGetir.Core.Entity;

namespace YapGetir.Model
{
    public class Kategori : BaseEntity
    {
        public Kategori()
        {
            Restorans = new HashSet<Restoran>();
            Tarifs = new HashSet<Tarif>();
            Uruns = new List<Urun>();
        }
        public string KategoriAdi { get; set; }
        public int KategoriTurID { get; set; }


        //maping

        public virtual ICollection<Restoran> Restorans { get; set; }
        public virtual ICollection<Tarif> Tarifs { get; set; }
        public virtual KategoriTur KategoriTur { get; set; }
        public virtual ICollection<Urun> Uruns { get; set; }

    }
}
