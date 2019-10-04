using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YapGetir.Core.Entity;

namespace YapGetir.Core.DAL.EntityFramework
{
    public class EFRepositoryBase<TEntity, TContext> : IRepository<TEntity> where TEntity : BaseEntity, new() //TEntity BaseEntity classından kalıtım almış nesne olabilir ve newlenebilir olmalı.
        where TContext:DbContext,new()
    {
        TContext ctx = EFSingletonContext<TContext>.Instance;//EFSingletonContext classının amacı Singleton pattern kullanarak nesne newlemek. Eğer newlenmiş nesne var onu bize verecek yoksa newleyecek yani instance alacak. EFSingletonContext classının Instance'ınıçağırdık bu kodla.

        public void Add(TEntity entity)
        {
            ctx.Entry(entity).State = EntityState.Added;
            ctx.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)//Linq sorguları göndemek için Expression kullanıyoruz bu sayede istediğimiz gibi filtreleme sorguları yazabiliyoruz.
        {
            return ctx.Set<TEntity>().Where(filter).SingleOrDefault();
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter==null)
            {
                return ctx.Set<TEntity>().ToList();
            }
            else
            {
                return ctx.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Remove(TEntity entity)
        {
            ctx.Entry(entity).State = EntityState.Deleted;
        }

        public void Update(TEntity entity)
        {
            ctx.Entry(entity).State = EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
