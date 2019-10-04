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
    public class OdemeService : IOdemeService
    {
        IOdemeDAL _odemeDAL;
        public OdemeService(IOdemeDAL odemeDAL)
        {
            _odemeDAL = odemeDAL;
        }
        public void Delete(Odeme entity)
        {
            _odemeDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Odeme odeme = _odemeDAL.Get(a => a.ID == entityID);
            _odemeDAL.Remove(odeme);
        }

        public Odeme Get(int entityID)
        {
            return _odemeDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Odeme> GetAll()
        {
            return _odemeDAL.GetAll();
        }

        public void Insert(Odeme entity)
        {
            _odemeDAL.Add(entity);
        }

        public void Update(Odeme entity)
        {
            _odemeDAL.Update(entity);
        }
    }
}
