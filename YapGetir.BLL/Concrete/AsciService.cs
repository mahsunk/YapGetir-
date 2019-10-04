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
    public class AsciService : IAsciService
    {
        IAsciDAL _asciDAL;
        public AsciService(IAsciDAL asciDAL)
        {
            _asciDAL = asciDAL;
        }

        public void Delete(Asci entity)
        {
            _asciDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Asci asci = _asciDAL.Get(a => a.ID == entityID);
            _asciDAL.Remove(asci);
        }

        public Asci Get(int entityID)
        {
            return _asciDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Asci> GetAll()
        {
            return _asciDAL.GetAll();
        }

        //restoran ID'ye göre Asci listelemek için bu metot yazıldı
        public List<Asci> getRestoranIDGoreAsci(int id)
        {
            return _asciDAL.GetAll(a => a.RestoranID == id).ToList();
        }

        public void Insert(Asci entity)
        {
            _asciDAL.Add(entity);
        }

        public void Update(Asci entity)
        {
            _asciDAL.Update(entity);
        }
    }
}
