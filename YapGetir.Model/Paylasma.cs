using YapGetir.Core.Entity;

namespace YapGetir.Model
{
    public class Paylasma : BaseEntity
    {
        public string PaylasmaTuru { get; set; }
        public int RestoranID { get; set; }
        public int AsciID { get; set; }
        public int TarifID { get; set; }

        //mapping

        public virtual Restoran Restoran { get; set; }
        public virtual Asci Asci { get; set; }
        public virtual Tarif Tarif { get; set; }

    }
}
