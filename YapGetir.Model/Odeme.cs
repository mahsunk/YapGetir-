using System.Collections.Generic;
using YapGetir.Core.Entity;

namespace YapGetir.Model
{
    public class Odeme : BaseEntity
    {
        public Odeme()
        {
            Siparis = new HashSet<Siparis>();
        }
        public string OdemeTipi { get; set; }


        //mapping
        public virtual ICollection<Siparis> Siparis { get; set; }

    }
}
