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
    public class KategoriTurService : IKategoriTurService
    {
        IKategoriTurDAL _kategoriTurDAL;
        public KategoriTurService(IKategoriTurDAL kategoriTurDAL)
        {
            _kategoriTurDAL = kategoriTurDAL;
        }

        public void Delete(KategoriTur entity)
        {
            _kategoriTurDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            KategoriTur kategoriTur = _kategoriTurDAL.Get(a => a.ID == entityID);
            _kategoriTurDAL.Remove(kategoriTur);
        }

        public KategoriTur Get(int entityID)
        {
            return _kategoriTurDAL.Get(a=>a.ID==entityID);
        }

        public ICollection<KategoriTur> GetAll()
        {
            return _kategoriTurDAL.GetAll();
        }

        public void Insert(KategoriTur entity)
        {
            _kategoriTurDAL.Add(entity);
        }

        public void Update(KategoriTur entity)
        {
            _kategoriTurDAL.Update(entity);
        }
    }
}
