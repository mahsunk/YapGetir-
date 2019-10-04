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
    public class TarifService : ITarifService
    {
        ITarifDAL _tarifDAL;
        public TarifService(ITarifDAL tarifDAL)
        {
            _tarifDAL = tarifDAL;
        }
        public void Delete(Tarif entity)
        {
            _tarifDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Tarif tarif = _tarifDAL.Get(a => a.ID == entityID);
            _tarifDAL.Remove(tarif);
        }

        public Tarif Get(int entityID)
        {
            return _tarifDAL.Get(a => a.ID == entityID); ;
        }

        public ICollection<Tarif> GetAll()
        {
            return _tarifDAL.GetAll();
        }

        public List<Tarif> GetByIdTarif(int id)
        {

            ICollection<Tarif> kategori = _tarifDAL.GetAll(a => a.KategoriID == id);
            return kategori as List<Tarif>;
        }

        public void Insert(Tarif entity)
        {
            _tarifDAL.Add(entity);
        }

        public void Update(Tarif entity)
        {
            _tarifDAL.Update(entity);
        }
    }
}
