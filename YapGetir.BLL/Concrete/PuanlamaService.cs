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
    public class PuanlamaService : IPuanlamaService
    {
        IPuanlamaDAL _puanlamaDAL;
        public PuanlamaService(IPuanlamaDAL puanlamaDAL)
        {
            _puanlamaDAL = puanlamaDAL;
        }
        public void Delete(Puanlama entity)
        {
            _puanlamaDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Puanlama puanlama = _puanlamaDAL.Get(a => a.ID == entityID);
            _puanlamaDAL.Remove(puanlama);
        }

        public Puanlama Get(int entityID)
        {
            return _puanlamaDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Puanlama> GetAll()
        {
            return _puanlamaDAL.GetAll();
        }

        public void Insert(Puanlama entity)
        {
            _puanlamaDAL.Add(entity);
        }

        public void Update(Puanlama entity)
        {
            _puanlamaDAL.Update(entity);
        }
    }
}
