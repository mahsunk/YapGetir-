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
    public class KategoriService : IKategoriService
    {
        IKategoriDAL _kategoriDAL;
        public KategoriService(IKategoriDAL kategoriDAL)
        {
            _kategoriDAL = kategoriDAL;
        }

        public void Delete(Kategori entity)
        {
            _kategoriDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Kategori kategori = _kategoriDAL.Get(a => a.ID == entityID);
            _kategoriDAL.Remove(kategori);
        }

        public Kategori Get(int entityID)
        {
            return _kategoriDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Kategori> GetAll()
        {
            return _kategoriDAL.GetAll();
        }

        public List<Kategori> GetByIdKategori(int id)
        {
            ICollection<Kategori> kategori = _kategoriDAL.GetAll(a => a.KategoriTurID == id);
            return kategori as List<Kategori>;
        }

        public void Insert(Kategori entity)
        {
            _kategoriDAL.Add(entity);
        }

        public void Update(Kategori entity)
        {
            _kategoriDAL.Update(entity);
        }
    }
}
