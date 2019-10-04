using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapGetir.BLL.Abstract;
using YapGetir.DTO;
using YapGetir.Model;
using YapGetir.UI.MVC.Models;

namespace YapGetir.UI.MVC.Controllers
{
    public class RestoranController : Controller
    {
        IUyeFormuService _uyeFormuService;
        ISiparisService _siparisService;
        IRestoranService _restoranService;
        ITedarikciService _tedarikciService;
        IAsciService _asciService;
        public RestoranController(IUyeFormuService uyeFormuService, ISiparisService siparisService, IRestoranService restoranService, ITedarikciService tedarikciService, IAsciService asciService)
        {
            _uyeFormuService = uyeFormuService;
            _siparisService = siparisService;
            _restoranService = restoranService;
            _tedarikciService = tedarikciService;
            _asciService = asciService;
        }

        [HttpPost]
        public void Onayla(int id)
        {
            Siparis siparis = _siparisService.Get(id);
            siparis.SiparisDurumu = "Onaylandı";
            _siparisService.Update(siparis);
        }

        public void OnayKaldir(int id)
        {
            Siparis siparis = _siparisService.Get(id);
            siparis.SiparisDurumu = "Onaylanmadı";
            _siparisService.Update(siparis);
        }


        // GET: Restoran
        public ActionResult Index()
        {
            if (Session["restoranKullanici"] != null)
            {

                int id = (Session["restoranKullanici"] as UyeFormu).ID;
                int restid = _restoranService.getUyeIDGoreRestoran(id).ID;

                SiparisMultiModel viewModel = new SiparisMultiModel();
                List<SiparisDTO> siparisler = new List<SiparisDTO>();
                foreach (var item in _siparisService.GetAll(x => x.RestoranID == restid).ToList())//Modeldeki navigation propertylerden diğer tablolardaki verilere erişebiliriz.
                {
                    siparisler.Add(new SiparisDTO
                    {
                        TarifAdi = item.Tarif.TarifAdi,
                        UyeAdiSoyadi = item.UyeFormu.UyeAdi + item.UyeFormu.UyeSoyadi,
                        AsciAdiSoyadi = item.Asci.AsciAdi,
                        SiparisID = item.ID,
                        TarifAciklama = item.Tarif.Aciklama

                    });
                }
                viewModel.siparisDTO = siparisler;//DTO ile istediğimiz verileri aldık

                return View(viewModel);


                // !!! Bu kodları silme örnek olarak dursun
                //SiparisMultiModel viewModel = new SiparisMultiModel();
                //List<SiparisDTO> siparisler = new List<SiparisDTO>();
                //foreach (var item in _siparisService.GetAll())//Modeldeki navigation propertylerden diğer tablolardaki verilere erişebiliriz.
                //{
                //    siparisler.Add(new SiparisDTO
                //    {
                //        TarifAdi = item.Tarif.TarifAdi,
                //        UyeAdiSoyadi = item.UyeFormu.UyeAdi + item.UyeFormu.UyeSoyadi,
                //        AsciAdiSoyadi = item.Asci.AsciAdi,
                //        SiparisID = item.ID,
                //        TarifAciklama = item.Tarif.Aciklama

                //    });
                //}
                //viewModel.siparisDTO = siparisler;//DTO ile istediğimiz verileri aldık


                //int id = (Session["restoranKullanici"] as UyeFormu).ID;
                //int restid = _restoranService.getRestoranUyeID(id).ID;
                //viewModel.siparis = _siparisService.GetAll(x=>x.RestoranID== restid).ToList();//Burada ise DTO kullanmadan gelen tüm verileri aldık bu şekilde çalışmak sayfayı yorar. 
                //return View(viewModel);

            }
            else
            {
                return RedirectToAction("Login", "Restoran");
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UyeFormu uyeFormu)
        {
            var gelenKullanici = _uyeFormuService.GetUserByLogin(uyeFormu.KullaniciAdi, uyeFormu.Sifre);

            if (gelenKullanici != null && gelenKullanici.TipID == 4)
            {
                Session["restoranKullanici"] = gelenKullanici;
                return RedirectToAction("Index", "Restoran");
            }
            ViewBag.Error = "Restoran Bulunamadı";
            return View();
        }

        public ActionResult Cikis()
        {
            Session["restoranKullanici"] = null;
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Stok()
        {
            if (Session["restoranKullanici"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Restoran");
            }
        }

        public ActionResult Tedarikciler()
        {
            if (Session["restoranKullanici"] != null)
            {
                int id = (Session["restoranKullanici"] as UyeFormu).ID;
                int rid = _restoranService.getUyeIDGoreRestoran(id).ID;
                return View(_tedarikciService.getRestoranIDGoreTedarikci(rid).ToList());
            }
            else
            {
                return RedirectToAction("Login", "Restoran");
            }
        }

        public ActionResult Ascilarim()
        {
            if (Session["restoranKullanici"] != null)
            {
                int id = (Session["restoranKullanici"] as UyeFormu).ID;
                int rid = _restoranService.getUyeIDGoreRestoran(id).ID;
                return View(_asciService.getRestoranIDGoreAsci(rid).ToList());
            }
            else
            {
                return RedirectToAction("Login", "Restoran");
            }
        }

        public ActionResult AsciSiparisCizelgesi()
        {
            if (Session["restoranKullanici"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Restoran");
            }
        }
    }
}