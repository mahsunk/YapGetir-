using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetir.Model;

namespace YapGetir.BLL.Abstract
{
    public interface IRestoranService: IBaseService<Restoran>
    {
        //Uye id'ye göre restoran çekmek için metot eklendi
        Restoran getUyeIDGoreRestoran(int id);
    }
}
