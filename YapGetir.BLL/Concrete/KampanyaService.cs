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
    public class KampanyaService : IKampanyaService
    {
        IKampanyaDAL _kampanyaDAL;
        public KampanyaService(IKampanyaDAL kampanyaDAL)
        {
            _kampanyaDAL = kampanyaDAL;
        }


        public void Delete(Kampanya entity)
        {
            _kampanyaDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Kampanya kampanya = _kampanyaDAL.Get(a => a.ID == entityID);
            _kampanyaDAL.Remove(kampanya);
        }

        public Kampanya Get(int entityID)
        {
            return _kampanyaDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Kampanya> GetAll()
        {
            return _kampanyaDAL.GetAll();
        }

        public void Insert(Kampanya entity)
        {
            _kampanyaDAL.Add(entity);
        }

        public void Update(Kampanya entity)
        {
            _kampanyaDAL.Update(entity);
        }
    }
}
