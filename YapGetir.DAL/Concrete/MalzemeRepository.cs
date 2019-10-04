using YapGetir.Core.DAL.EntityFramework;
using YapGetir.DAL.Abstract;
using YapGetir.Model;

namespace YapGetir.DAL.Concrete
{
    public class MalzemeRepository : EFRepositoryBase<Malzeme, YapGetirDbContext>, IMalzemeDAL
    {
    }
}
