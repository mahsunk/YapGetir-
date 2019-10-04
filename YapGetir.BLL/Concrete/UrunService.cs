using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetir.BLL.Abstract;
using YapGetir.DAL.Abstract;
using YapGetir.Model;

namespace YapGetir.BLL.Concrete
{
    public class UrunService : IUrunService
    {
        IUrunDAL _urunDAL;
        public UrunService(IUrunDAL urunDAL)
        {
            _urunDAL = urunDAL;
        }
        public void Delete(Urun entity)
        {
            _urunDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Urun urun = _urunDAL.Get(a => a.ID == entityID);
            _urunDAL.Remove(urun);
        }

        public Urun Get(int entityID)
        {
            return _urunDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Urun> GetAll()
        {
            return _urunDAL.GetAll();
        }

        public void Insert(Urun entity)
        {
            _urunDAL.Add(entity);
        }

        public void Update(Urun entity)
        {
            _urunDAL.Update(entity);
        }
    }
}
