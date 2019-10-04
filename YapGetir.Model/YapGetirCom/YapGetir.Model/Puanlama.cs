using System.Collections.Generic;
using YapGetir.Core.Entity;

namespace YapGetir.Model
{
    public class Puanlama : BaseEntity
    {
        public Puanlama()
        {
            Restorans = new HashSet<Restoran>();
            Ascis = new HashSet<Asci>();
            Tarifs = new HashSet<Tarif>();
        }

        public byte PuanlamaTuru { get; set; }

        //mapping
        public virtual ICollection<Restoran> Restorans { get; set; }
        public virtual ICollection<Asci> Ascis { get; set; }
        public virtual ICollection<Tarif> Tarifs { get; set; }



    }
}
