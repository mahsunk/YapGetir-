using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using YapGetir.BLL.Abstract;
using YapGetir.Model;

namespace YapGetir.UI.MVC.Controllers
{
    public class TedarikciController : Controller
    {
        IUyeFormuService _uyeFormuService;
        IMalzemeService _malzemeService;

        public TedarikciController(IUyeFormuService uyeFormuService, IMalzemeService malzemeService)
        {
            _uyeFormuService = uyeFormuService;
            _malzemeService = malzemeService;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UyeFormu uyeFormu)
        {
            var gelenKullanici = _uyeFormuService.GetUserByLogin(uyeFormu.KullaniciAdi, uyeFormu.Sifre);

            if (gelenKullanici != null && gelenKullanici.TipID == 3)
            {
                Session["tedarikciKullanici"] = gelenKullanici;
                return RedirectToAction("Index", "Tedarikci");
            }
            ViewBag.Error = "Tedarikci Bulunamadı";
            return View();
        }

        public ActionResult Index(UyeFormu uyeFormu)
        {
            if (Session["tedarikciKullanici"] != null)
            {
                return View(_malzemeService.GetAll().ToList());
            }
            else
            {
                return RedirectToAction("Login", "Tedarikci");
            }
        }

        public ActionResult Cikis()
        {
            //Session["tedarikciKullanici"] = null;
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult YapGetirMesajGonder()
        {
            if (Session["tedarikciKullanici"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Tedarikci");
            }
        }

        public ActionResult RestoranaMesajGonder()
        {
            if (Session["tedarikciKullanici"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Tedarikci");
            }
        }
    }
}