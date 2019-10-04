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
    public class MalzemeService : IMalzemeService
    {
        IMalzemeDAL _malzemeDAL;
        public MalzemeService(IMalzemeDAL malzemeDAL)
        {
            _malzemeDAL = malzemeDAL;
        }

        public void Delete(Malzeme entity)
        {
            _malzemeDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Malzeme malzeme = _malzemeDAL.Get(a => a.ID == entityID);
            _malzemeDAL.Remove(malzeme);
        }

        public Malzeme Get(int entityID)
        {
            return _malzemeDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Malzeme> GetAll()
        {
            return _malzemeDAL.GetAll();
        }

        public List<Malzeme> GetByIdMalzeme(int id)
        {
            ICollection<Malzeme> malzeme = _malzemeDAL.GetAll(a => a.TarifID == id);
            return malzeme as List<Malzeme>;
        }

        public void Insert(Malzeme entity)
        {
            _malzemeDAL.Add(entity);
        }

        public void Update(Malzeme entity)
        {
            _malzemeDAL.Update(entity);
        }
    }
}
