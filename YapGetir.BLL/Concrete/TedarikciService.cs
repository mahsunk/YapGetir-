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
    public class TedarikciService : ITedarikciService
    {
        ITedarikciDAL _tedarikciDAL;
        public TedarikciService(ITedarikciDAL tedarikciDAL)
        {
            _tedarikciDAL = tedarikciDAL;
        }
        public void Delete(Tedarikci entity)
        {
            _tedarikciDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Tedarikci tedarikci = _tedarikciDAL.Get(a => a.ID == entityID);
            _tedarikciDAL.Remove(tedarikci);
        }

        public Tedarikci Get(int entityID)
        {
            return _tedarikciDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Tedarikci> GetAll()
        {
            return _tedarikciDAL.GetAll();
        }

        //restoran ID'ye göre tedarikçi getirmek için bu metot eklendi
        public List<Tedarikci> getRestoranIDGoreTedarikci(int id)
        {
            return _tedarikciDAL.GetAll(a => a.RestoranID == id).ToList();
        }

        public void Insert(Tedarikci entity)
        {
            _tedarikciDAL.Add(entity);
        }

        public void Update(Tedarikci entity)
        {
            _tedarikciDAL.Update(entity);
        }
    }
}
