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
    public class YorumService : IYorumService
    {
        IYorumDAL _yorumDAL;
        public YorumService(IYorumDAL yorumDAL)
        {
            _yorumDAL = yorumDAL;
        }

        public void Delete(Yorum entity)
        {
            _yorumDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Yorum yorum = _yorumDAL.Get(a => a.ID == entityID);
            _yorumDAL.Remove(yorum);
        }

        public Yorum Get(int entityID)
        {
            return _yorumDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Yorum> GetAll()
        {
            return _yorumDAL.GetAll();
        }

        public void Insert(Yorum entity)
        {
            _yorumDAL.Add(entity);
        }

        public void Update(Yorum entity)
        {
            _yorumDAL.Update(entity);
        }
    }
}
