using System;
using System.Data.Entity;
using System.Linq.Expressions;
using YapGetir.Core.DAL.EntityFramework;
using YapGetir.DAL.Abstract;
using YapGetir.Model;

namespace YapGetir.DAL.Concrete
{
    public class UyeFormuRepository : EFRepositoryBase<UyeFormu, YapGetirDbContext>, IUyeFormuDAL
    {
    }
}
