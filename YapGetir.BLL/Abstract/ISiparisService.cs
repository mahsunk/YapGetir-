using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YapGetir.Model;

namespace YapGetir.BLL.Abstract
{
    public interface ISiparisService: IBaseService<Siparis>
    {
        ICollection<Siparis> GetAll(Expression<Func<Siparis, bool>> filter = null);

    }
}
