using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YapGetir.Model;

namespace YapGetir.BLL.Abstract
{
    public interface IKategoriService: IBaseService<Kategori>
    {
       List<Kategori> GetByIdKategori(int id);
      
        // ICollection<Kategori> GetByIDKategori(Expression<Func<Siparis, bool>> filter = null);
    }
}
