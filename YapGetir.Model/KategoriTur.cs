using System.Collections.Generic;
using YapGetir.Core.Entity;

namespace YapGetir.Model
{
    public class KategoriTur : BaseEntity
    {
        public KategoriTur()
        {
            Kategoris = new HashSet<Kategori>();
        }

        public string TurAdi { get; set; }
        //mapping

        public virtual ICollection<Kategori> Kategoris { get; set; }
    }
}
