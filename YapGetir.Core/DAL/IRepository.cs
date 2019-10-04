using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YapGetir.Core.Entity;

namespace YapGetir.Core.DAL
{
    public interface IRepository<TEntity> where TEntity: BaseEntity// where TEntity : BaseEntity demek TEntity Generic tipi BaseEntity classından kalıtım almış classlar olabilir.
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter = null);//Linq sorguları göndemek için Expression kullanıyoruz bu sayede istediğimiz gibi filtreleme sorguları yazabiliyoruz.
        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
    }
}
