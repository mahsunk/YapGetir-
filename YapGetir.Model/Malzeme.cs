using YapGetir.Core.Entity;

namespace YapGetir.Model
{
    public class Malzeme : BaseEntity
    {
        public string MalzemeAdi { get; set; }
        public string MazlemeOlcumu { get; set; }
        public string MalzemeMiktari { get; set; }
        public int TarifID { get; set; }
        public decimal MalzemeTutari { get; set; }

        //mapping

        public virtual Tarif Tarif { get; set; }
    }
}
