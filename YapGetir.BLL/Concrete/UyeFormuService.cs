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
    public class UyeFormuService : IUyeFormuService
    {
        IUyeFormuDAL _uyeFormuDAL;
        public UyeFormuService(IUyeFormuDAL uyeFormuDAL)
        {
            _uyeFormuDAL = uyeFormuDAL;
        }

        public void Delete(UyeFormu entity)
        {
            _uyeFormuDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            UyeFormu uyeFormu = _uyeFormuDAL.Get(a => a.ID == entityID);
            _uyeFormuDAL.Remove(uyeFormu);
        }

        public UyeFormu Get(int entityID)
        {
            return _uyeFormuDAL.Get(a => a.ID == entityID);
        }

        public ICollection<UyeFormu> GetAll()
        {
            return _uyeFormuDAL.GetAll();
        }

        public UyeFormu GetUserByLogin(string UserName, string password)
        {
            return _uyeFormuDAL.Get(a => a.KullaniciAdi == UserName && a.Sifre == password);
        }

        public void Insert(UyeFormu entity)
        {
            _uyeFormuDAL.Add(entity);
        }

        public void sifreGuncelle(UyeFormu uyeFormu)
        {
            ICollection<UyeFormu> uyeler=this.GetAll();
            UyeFormu uye =  uyeler.FirstOrDefault(a => a.KullaniciAdi == uyeFormu.KullaniciAdi);
            uye.Sifre = uyeFormu.Sifre;
            this.Update(uye);
        }

        public void Update(UyeFormu entity)
        {
            _uyeFormuDAL.Update(entity);
        }
    }
}
