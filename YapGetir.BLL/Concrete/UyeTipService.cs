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
    public class UyeTipService : IUyeTipService
    {
        IUyeTipDAL _uyeTipDAL;
        public UyeTipService(IUyeTipDAL uyeTipDAL)
        {
            _uyeTipDAL = uyeTipDAL;
        }

        public void Delete(UyeTip entity)
        {
            _uyeTipDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            UyeTip uyeTip = _uyeTipDAL.Get(a => a.ID == entityID);
        }

        public UyeTip Get(int entityID)
        {
            return _uyeTipDAL.Get(a => a.ID == entityID);
        }

        public ICollection<UyeTip> GetAll()
        {
            return _uyeTipDAL.GetAll();
        }

        public void Insert(UyeTip entity)
        {
            _uyeTipDAL.Add(entity);
        }

        public void Update(UyeTip entity)
        {
            _uyeTipDAL.Update(entity);
        }
    }
}
