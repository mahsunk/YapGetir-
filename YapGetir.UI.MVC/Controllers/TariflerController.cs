using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapGetir.BLL.Abstract;
using YapGetir.BLL.Concrete;
using YapGetir.Model;

namespace YapGetir.UI.MVC.Controllers
{
    public class TariflerController : Controller
    {
        IKategoriTurService _kategoriTurService;
        IKategoriService _kategoriService;
        ITarifService _tarifService;
        IMalzemeService  _malzemeService ;
        IUrunService _urunService;
        static List<Malzeme> malzemes = new List<Malzeme>();
        // GET: Tarifler
        public TariflerController(IUrunService urunService, IMalzemeService malzemeService, ITarifService tarifService , IKategoriService kategoriService, IKategoriTurService kategoriTurService)
        {
            _kategoriTurService = kategoriTurService;
            _kategoriService = kategoriService;
            _tarifService = tarifService;
            _malzemeService = malzemeService;
            _urunService = urunService;
        }
        public ActionResult Index()
        {
            var kategori = _kategoriService.GetAll();


            return View(kategori);
        }

       
        public ActionResult Listele(int catID)
        {

            ICollection<Tarif> kategoriList;


            kategoriList = _tarifService.GetByIdTarif(catID) as ICollection<Tarif>;


            return View(kategoriList);

        }

        public ActionResult MalzemeListele(int tarifID ,string tarifAdi)
        {
            Tarif tarif = _tarifService.Get(tarifID);
            ViewBag.Aciklama = tarif.Aciklama;

            ICollection<Malzeme> kategoriList;
            ViewBag.tarifadi = tarifAdi;

            kategoriList = _malzemeService.GetByIdMalzeme(tarifID) as ICollection<Malzeme>;


            return View(kategoriList);

        }

        public ActionResult TarifOlustur()
        {
            List<SelectListItem> BagisTurleri = new List<SelectListItem>();
            foreach (var item in _kategoriService.GetAll().ToList())
            {
                BagisTurleri.Add(new SelectListItem
                {
                    Text = item.KategoriAdi,
                    Value = item.ID.ToString()
                });
            }
            ViewBag.Tipler = BagisTurleri;


            return View();
        }
        [HttpPost]
        public ActionResult TarifOlustur(Tarif tarif)
        {
             
            try
            {
               
                _tarifService.Insert(tarif);

            }
            catch (Exception ex)
            {
                ViewBag.Error = "Kayıdınız gerçekleştirilemedi";
                return View();
            }
            return RedirectToAction("MalzemeOluştur", "Tarifler");
        }
        public ActionResult MalzemeOluştur()
        {
            List<SelectListItem> BagisTurleri = new List<SelectListItem>();
            foreach (var item in _urunService.GetAll())
            {
                BagisTurleri.Add(new SelectListItem
                {
                    Text = item.UrunAdi,
                    Value = item.ID.ToString()
                });
            }
            ViewBag.Tipler = BagisTurleri;


            return View();


           
        }



    }
}