﻿using YapGetir.Core.DAL.EntityFramework;
using YapGetir.DAL.Abstract;
using YapGetir.Model;

namespace YapGetir.DAL.Concrete
{
    public class RestoranRepository : EFRepositoryBase<Restoran, YapGetirDbContext>, IRestoranDAL
    {
    }
}
