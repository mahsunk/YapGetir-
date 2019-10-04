using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetir.Model;

namespace YapGetir.BLL.Abstract
{
    public interface ITedarikciService: IBaseService<Tedarikci>
    {
        //restoran ID'ye göre tedarikçi getirmek için bu metot eklendi
        List<Tedarikci> getRestoranIDGoreTedarikci(int id);
    }
}
