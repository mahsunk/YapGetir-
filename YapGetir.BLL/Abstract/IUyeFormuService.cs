using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetir.Model;

namespace YapGetir.BLL.Abstract
{
    public interface IUyeFormuService: IBaseService<UyeFormu>
    {
        UyeFormu GetUserByLogin(string UserName, string password);
        void sifreGuncelle(UyeFormu uyeFormu);
    }
}
