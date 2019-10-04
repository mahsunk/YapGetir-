using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YapGetir.DTO;
using YapGetir.Model;

namespace YapGetir.UI.MVC.Models
{
    public class SiparisMultiModel//Bir sayfaya birden fazla model göndermek istersek böyle bir class oluşturuyoruz ve içine göndermek istediğimiz sınıfları yazıyor.
    {
        public List<SiparisDTO> siparisDTO { get; set; }
        public List<Siparis> siparis { get; set; }
    }
}