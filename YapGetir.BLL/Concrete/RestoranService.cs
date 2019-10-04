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
    public class RestoranService : IRestoranService
    {
        IRestoranDAL _restoranDAL;
        public RestoranService(IRestoranDAL restoranDAL)
        {
            _restoranDAL = restoranDAL;
        }
        public void Delete(Restoran entity)
        {
            _restoranDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Restoran restoran = _restoranDAL.Get(a => a.ID == entityID);
            _restoranDAL.Remove(restoran);
        }

        public Restoran Get(int entityID)
        {
            return _restoranDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Restoran> GetAll()
        {
            return _restoranDAL.GetAll();
        }

        //Uye id'ye göre restoran çekmek için bu metodu ekledik
        public Restoran getUyeIDGoreRestoran(int id)
        {
            return _restoranDAL.Get(a => a.UyeID == id);
        }

        public void Insert(Restoran entity)
        {
            _restoranDAL.Add(entity);
        }

        public void Update(Restoran entity)
        {
            _restoranDAL.Update(entity);
        }
    }
}
