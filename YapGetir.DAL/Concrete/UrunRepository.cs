using YapGetir.Core.DAL.EntityFramework;
using YapGetir.DAL.Abstract;
using YapGetir.Model;

namespace YapGetir.DAL.Concrete
{
    public class UrunRepository : EFRepositoryBase<Urun, YapGetirDbContext>, IUrunDAL
    {
    }
}
