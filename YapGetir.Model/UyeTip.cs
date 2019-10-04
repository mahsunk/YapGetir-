using System.Collections.Generic;
using YapGetir.Core.Entity;

namespace YapGetir.Model
{
    public class UyeTip : BaseEntity
    {
        public UyeTip()
        {
            UyeFormus = new HashSet<UyeFormu>();
        }
        public string TipAdi { get; set; }



        //Mapping
        public virtual ICollection<UyeFormu> UyeFormus { get; set; }
    }
}
