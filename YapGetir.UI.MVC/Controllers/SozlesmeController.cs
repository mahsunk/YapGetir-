using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Yapgetir.UI.MVC.Controllers
{
    public class SozlesmeController : Controller
    {
        // GET: Sozlesme
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Gizlilik()
        {
            return View();
        }
        public ActionResult AydinlatmaMetni()
        {
            return View();
        }
        public ActionResult Kvk()
        {
            return View();
        }
    }
}