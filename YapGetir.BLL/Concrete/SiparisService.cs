using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YapGetir.BLL.Abstract;
using YapGetir.DAL.Abstract;
using YapGetir.Model;

namespace YapGetir.BLL.Concrete
{
    public class SiparisService : ISiparisService
    {
        ISiparisDAL _siparisDAL;
        public SiparisService(ISiparisDAL siparisDAL)
        {
            _siparisDAL = siparisDAL;
        }
        public void Delete(Siparis entity)
        {
            _siparisDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Siparis siparis = _siparisDAL.Get(a => a.ID == entityID);
            _siparisDAL.Remove(siparis);
        }

        public Siparis Get(int entityID)
        {
            return _siparisDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Siparis> GetAll()
        {
            return _siparisDAL.GetAll();
        }

        public ICollection<Siparis> GetAll(Expression<Func<Siparis, bool>> filter = null)
        {
            return _siparisDAL.GetAll(filter);
        }

        public void Insert(Siparis entity)
        {
            _siparisDAL.Add(entity);
        }

        public void Update(Siparis entity)
        {
            _siparisDAL.Update(entity);
        }
    }
}
