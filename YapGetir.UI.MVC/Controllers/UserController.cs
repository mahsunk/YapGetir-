using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapGetir.BLL.Abstract;
using YapGetir.BLL.Concrete;
using YapGetir.DTO;
using YapGetir.Model;
using YapGetir.UI.MVC.Tools;

namespace YapGetir.UI.MVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        IUyeFormuService _uyeFormuService;
        IUyeTipService _uyeTipService;
        ISiparisService _siparisService;
        public UserController(IUyeFormuService uyeFormuService, IUyeTipService uyeTipService, ISiparisService siparisService)
        {
            _uyeFormuService = uyeFormuService;
            _uyeTipService = uyeTipService;
            _siparisService = siparisService;
        }
        [AdminFilter]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cikis()
        {
            Session["beniHatırla"] = null;
            Session["kullanici"] = null;
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Register()
        {
            List<SelectListItem> BagisTurleri = new List<SelectListItem>();
            foreach (var item in _uyeTipService.GetAll())
            {
                BagisTurleri.Add(new SelectListItem
                {
                    Text = item.TipAdi,
                    Value = item.ID.ToString()
                });
            }
            ViewBag.Tipler = BagisTurleri;
            return View();
        }

        [HttpPost]
        public ActionResult Register(UyeFormu uyeFormu)
        {
            try
            {
                _uyeFormuService.Insert(uyeFormu);

            }
            catch (Exception)
            {
                ViewBag.Error = "Kayıdınız gerçekleştirilemedi";
                return View();
            }
            return RedirectToAction("index", "Home");
        }

        public ActionResult Profil()
        {
            return View();
        }


        public ActionResult ProfilDuzenle(int uyeID)
        {
            List<SelectListItem> BagisTurleri = new List<SelectListItem>();
            foreach (var item in _uyeTipService.GetAll())
            {
                BagisTurleri.Add(new SelectListItem
                {
                    Text = item.TipAdi,
                    Value = item.ID.ToString()
                });
            }
            ViewBag.Tipler = BagisTurleri;

            return View(_uyeFormuService.Get(uyeID));
        }

        [HttpPost]
        public ActionResult ProfilDuzenle(UyeFormu uye)
        {

            try
            {
                UyeFormu temUye = _uyeFormuService.Get(uye.ID);
                temUye.UyeAdi = uye.UyeAdi;
                temUye.UyeSoyadi = uye.UyeSoyadi;
                temUye.KullaniciAdi = uye.KullaniciAdi;
                temUye.Sifre = uye.Sifre;
                temUye.Semt = uye.Semt;
                temUye.DogumTarihi = uye.DogumTarihi;
                temUye.TipID = uye.TipID;

                _uyeFormuService.Update(temUye);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Güncelleştirme gerçekleştirilemedi";
                return View();
            }



            return RedirectToAction("Profil", "User");
        }

        public ActionResult Siparislerim()
        {
            //Kullanici girişi yapılmadıysa ana sayfaya yönlendirme yapacak, daha sonra eklenecek.
            //ICollection<Siparis> uyeSiparisleri = _siparisService.GetAll(a => a.UyeID == 1);
            if (Session["kullanici"] != null)
            {

                UyeFormu uyeninBilgileri = (Session["kullanici"] as UyeFormu);
                List<UyeSiparislerDTO> siparisler = new List<UyeSiparislerDTO>();
                foreach (var item in _siparisService.GetAll(x => x.UyeID == uyeninBilgileri.ID).ToList())//Modeldeki navigation propertylerden diğer tablolardaki verilere erişebiliriz.
                {
                    siparisler.Add(new UyeSiparislerDTO
                    {
                        SiparisID = item.ID,
                        TarifAdi = item.Tarif.TarifAdi,
                        TarifAciklama = item.Tarif.Aciklama,
                        RestoranAdi = item.Restoran.RestoranAdi,
                        RestoranID = item.RestoranID,
                        AsciAdiSoyadi = item.Asci.AsciAdi,
                        Tutar = item.SiparisTutari,
                        OdemeTipi = item.Odeme.OdemeTipi
                    });
                }
                return View(siparisler);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult MesajGonder(string RestoranAdi)
        {
            if (Session["kullanici"] != null)
            {
                ViewBag.restoranadi = RestoranAdi;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}