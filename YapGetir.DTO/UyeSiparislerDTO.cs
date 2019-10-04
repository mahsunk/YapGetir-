using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapGetir.DTO
{
    public class UyeSiparislerDTO
    {
        public int SiparisID { get; set; }
        public string TarifAdi { get; set; }
        public string TarifAciklama { get; set; }
        public string AsciAdiSoyadi { get; set; }
        public string RestoranAdi { get; set; }
        public int RestoranID { get; set; }
        public decimal Tutar { get; set; }
        public string OdemeTipi { get; set; }
    }
}
