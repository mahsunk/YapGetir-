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
    public class PaylasmaService : IPaylasmaService
    {
        IPaylasmaDAL _paylasmaDAL;
        public PaylasmaService(IPaylasmaDAL paylasmaDAL)
        {
            _paylasmaDAL = paylasmaDAL;
        }
        public void Delete(Paylasma entity)
        {
            _paylasmaDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Paylasma paylasma = _paylasmaDAL.Get(a => a.ID == entityID);
            _paylasmaDAL.Remove(paylasma);
        }

        public Paylasma Get(int entityID)
        {
            return _paylasmaDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Paylasma> GetAll()
        {
            return _paylasmaDAL.GetAll();
        }

        public void Insert(Paylasma entity)
        {
            _paylasmaDAL.Add(entity);
        }

        public void Update(Paylasma entity)
        {
            _paylasmaDAL.Update(entity);
        }
    }
}
