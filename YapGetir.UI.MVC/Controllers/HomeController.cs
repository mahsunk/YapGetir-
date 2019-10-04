using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapGetir.BLL.Abstract;
using YapGetir.Model;
using YapGetir.UI.MVC.Models;
using YapGetir.UI.MVC.Tools;

namespace YapGetir.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        IUyeFormuService _uyeFormuService;
        public HomeController(IUyeFormuService uyeFormuService)
        {
            _uyeFormuService = uyeFormuService;
        }
        // GET: Home

        [LoginFilter]
        public ActionResult Index()
        {

           
            return View();


        }
     
       [HttpPost]
        public ActionResult Index(LoginDTO uyeFormu)
        {

            var gelenKullanici = _uyeFormuService.GetUserByLogin(uyeFormu.Username, uyeFormu.Password);
          
            if (gelenKullanici != null)
            {
                if(uyeFormu.Isaretlendimi)
                { Session["beniHatırla"] = gelenKullanici; }
                Session["kullanici"] = gelenKullanici;
                return RedirectToAction("Index", "User");
            }
            ViewBag.Error = "Kullanıcı Bulunamadı";
            return View();


        }

        public ActionResult SifreUnuttum()
        {
              return View();

        }

        [HttpPost]
        public ActionResult SifreUnuttum(UyeFormu uye)
        {
            try
            {
                UyeFormu yeniSifre = new UyeFormu();
                yeniSifre.KullaniciAdi = uye.KullaniciAdi;
                Random rnd = new Random();
                yeniSifre.Sifre = rnd.Next(100000, 999999).ToString();
                //db de şifre alanını güncelle sifre değişkeni ile
                //sifre değişkenini mail at.
                _uyeFormuService.sifreGuncelle(yeniSifre);
                string mesaj="Sifreniz sıfırlanmıstır."+"  "+ "Yeni Şifreniz :" + yeniSifre.Sifre;
                bool sonuc = MailHelper.SendConfirmationMail(mesaj, uye.KullaniciAdi);
                if (!sonuc)
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {

                 ViewBag.Error = "Şifre Sıfırlama Gerceklesmedi gerçekleştirilemedi";
                return View();
            }
            return RedirectToAction("Index", "Home");

        }
    }
}