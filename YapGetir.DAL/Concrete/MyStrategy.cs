using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetir.Model;

namespace YapGetir.DAL.Concrete
{
    public class MyStrategy : DropCreateDatabaseIfModelChanges<YapGetirDbContext>
    {
        protected override void Seed(YapGetirDbContext context)
        {
            var uyeTipleri = new List<UyeTip>
            {
                new UyeTip{ID=1,TipAdi="Kullanici" },
                new UyeTip{ID=2,TipAdi="Admin" },
                new UyeTip{ID=3,TipAdi="Tedarikci" },
                new UyeTip{ID=4,TipAdi="Restoran" }
            };

            var uyeFormu = new List<UyeFormu>
            {
                new UyeFormu{ID=1, UyeAdi="Ali",UyeSoyadi="Sayın",KullaniciAdi="alisayin@gmail.com",Sifre="ali",Semt="bakirköy",DogumTarihi=new DateTime(1991,02,02,00,00,00),TipID=3 },
                new UyeFormu{ID=2, UyeAdi="Burhan",UyeSoyadi="Telli",KullaniciAdi="burhantelli@gmail.com",Sifre="burhan",Semt="küçükçekmece",DogumTarihi=new DateTime(1993,03,03,00,00,00),TipID=4 },
                new UyeFormu{ID=3, UyeAdi="Ceyhun",UyeSoyadi="Dereli",KullaniciAdi="ceyhun@gmail.com",Sifre="ceyhun",Semt="kadıköy",DogumTarihi=new DateTime(1994,04,05,00,00,00),TipID=4 },
                new UyeFormu{ID=4, UyeAdi="Deniz",UyeSoyadi="Mihralı",KullaniciAdi="deniz@gmail.com",Sifre="deniz",Semt="bakirköy",DogumTarihi=new DateTime(1995,05,05,00,00,00),TipID=3 }
            };
            //1996-07-04 00:00:00.000
            var puanlama = new List<Puanlama>
            {
                new Puanlama{ID=1,PuanlamaTuru=5},
                new Puanlama{ID=2,PuanlamaTuru=4},
                new Puanlama{ID=3,PuanlamaTuru=3},
                new Puanlama{ID=4,PuanlamaTuru=2},
                new Puanlama{ID=5,PuanlamaTuru=1},
            };

            var kategoriTur = new List<KategoriTur>
            {
                new KategoriTur{ID=1,TurAdi="Etçi"},
                new KategoriTur{ID=2,TurAdi="Dönerci"},
                new KategoriTur{ID=3,TurAdi="Dünya Mutfağı"}
            };

            var kategoriAdi = new List<Kategori>
            {
                new Kategori{ID=1,KategoriAdi="Dünya Mutfağı",KategoriTurID=3},
                new Kategori{ID=2, KategoriAdi="Tavuk Eti",KategoriTurID=2},
                new Kategori{ID=3, KategoriAdi="Sarma",KategoriTurID=3},
                new Kategori{ID=4,KategoriAdi="Dolma",KategoriTurID=1},
            };

            var Restoran = new List<Restoran>
            {
                new Restoran{ID=1,RestoranAdi="Nusr-Et", KategoriID=1,Favorimi=false,StoktakiMalzemeKontrol=false,PuanlamaID=1,UyeID=2},
                new Restoran{ID=2,RestoranAdi="Döner Dünyası", KategoriID=2,Favorimi=false,StoktakiMalzemeKontrol=false,PuanlamaID=2,UyeID=3}
            };

            var Asci = new List<Asci>
            {
                new Asci{ID=1,AsciAdi="Nusret Chef",RestoranID=1,PuanlamaID=1},
                new Asci{ID=2,AsciAdi="Ahmet Haktan",RestoranID=1,PuanlamaID=2},
                new Asci{ID=3,AsciAdi="Niyazi Yemen",RestoranID=1,PuanlamaID=3},
                new Asci{ID=4,AsciAdi="Uygur Yaman",RestoranID=1,PuanlamaID=4},
                new Asci{ID=5,AsciAdi="Şamil Deniz",RestoranID=2,PuanlamaID=1},
                new Asci{ID=6,AsciAdi="Füsun Uzun",RestoranID=2,PuanlamaID=2},
                new Asci{ID=7,AsciAdi="Deniz Derya",RestoranID=2,PuanlamaID=3},
                new Asci{ID=8,AsciAdi="Yasemin Çiçek",RestoranID=2,PuanlamaID=4}
            };

            var odeme = new List<Odeme>
            {
                new Odeme{ID=1,OdemeTipi="Nakit"},
                new Odeme{ID=2,OdemeTipi="Kredi Kartı"}
            };


            var siparis = new List<Siparis>
            {
                new Siparis{TarifID=1,SiparisTarihi=new DateTime(2019,07,07,00,00,00),OdemeTipiID=1,TeslimatAdresi="bakırköy",SiparisDurumu="Onay Bekliyor",RestoranID=1,AsciID=1,UyeID=2,SiparisTutari=45},
                new Siparis{TarifID=2,SiparisTarihi=new DateTime(2019,07,11,00,00,00),OdemeTipiID=2,TeslimatAdresi="bakırköy",SiparisDurumu="Onay Bekliyor",RestoranID=2,AsciID=1,UyeID=1,SiparisTutari=55},
                new Siparis{TarifID=1,SiparisTarihi=new DateTime(2019,07,10,00,00,00),OdemeTipiID=1,TeslimatAdresi="kadıköy",SiparisDurumu="Onay Bekliyor",RestoranID=1,AsciID=1,UyeID=1,SiparisTutari=35},
                new Siparis{TarifID=1,SiparisTarihi=new DateTime(2019,07,11,00,00,00),OdemeTipiID=1,TeslimatAdresi="küçükçekmece",SiparisDurumu="Onay Bekliyor",RestoranID=2,AsciID=1,UyeID=1,SiparisTutari=30}
            };

            var tedarikci = new List<Tedarikci>
            {
                new Tedarikci{ID=1, TedarikciFirmaAdi="Sütiş A.Ş",Adres="incirli caddesi bakırköy", Şehir="İstanbul", TelefonNO="02124567896", Ulke="Türkiye", UyeID=1,RestoranID=2},
                new Tedarikci{ID=2, TedarikciFirmaAdi="Sabancı Et",Adres="alibeyköy caddesin no : 7/8 Başakşehir",Şehir="İstanbul",TelefonNO="02125634789", Ulke="Türkiye", UyeID=4, RestoranID=1},
                new Tedarikci{ID=3, TedarikciFirmaAdi="Torku",Adres="Konya çumra", Şehir="Konya", TelefonNO="03325647896", Ulke="Türkiye", UyeID=4,RestoranID=1}
            };

            var malzeme = new List<Malzeme>
            {
                new Malzeme{ID=1, MalzemeAdi="Süt",MazlemeOlcumu="litre",MalzemeMiktari="100",TarifID=1,MalzemeTutari=200},
                new Malzeme{ID=2,MalzemeAdi="Et",MazlemeOlcumu="kg",MalzemeMiktari="100",TarifID=2,MalzemeTutari=6000},
                new Malzeme{ID=3,MalzemeAdi="Ekmek",MazlemeOlcumu="Adet",MalzemeMiktari="10",TarifID=1,MalzemeTutari=50},
                new Malzeme{ID=4,MalzemeAdi="Pirinç",MazlemeOlcumu="kg",MalzemeMiktari="7",TarifID=2,MalzemeTutari=49},
            };

            var tarif = new List<Tarif>
            {
                new Tarif{ID=1,TarifAdi="Elmalı Kek",KategoriID=1,Aciklama="Hamur, elma, tarçın",Favorimi=false,PuanlamaID=1},
                new Tarif{ID=2,TarifAdi="Kuru Fasulye",KategoriID=1,Aciklama="Kuru fasulye birazda kavurma",Favorimi=false,PuanlamaID=2},
                new Tarif{ID=3,TarifAdi="Tavuk Döner",KategoriID=2,Aciklama="Marul, domates, patates kızartması",Favorimi=false,PuanlamaID=3},
                new Tarif{ID=3,TarifAdi="İstanbul Tavuk Döner",KategoriID=2,Aciklama="İçinde turşu, domates, patates kızartması",Favorimi=false,PuanlamaID=3},
                new Tarif{ID=3,TarifAdi="Lahana Sarması",KategoriID=3,Aciklama="Kırmızı et, pirinç bol",Favorimi=false,PuanlamaID=3},
                new Tarif{ID=3,TarifAdi="Yaprak Sarması",KategoriID=3,Aciklama="Tamamen kırmızı etten",Favorimi=false,PuanlamaID=3},
                new Tarif{ID=3,TarifAdi="Yeşil Biber Dolması",KategoriID=4,Aciklama="Tamamen kırmızı etten",Favorimi=false,PuanlamaID=1},
                new Tarif{ID=3,TarifAdi="Kırmızı Biber Dolması",KategoriID=4,Aciklama="Tamamen kırmızı etten",Favorimi=false,PuanlamaID=1},
                new Tarif{ID=3,TarifAdi="Patates Dolması",KategoriID=4,Aciklama="Tamamen kırmızı etten",Favorimi=false,PuanlamaID=1},
            };

            context.UyeTip.AddRange(uyeTipleri);//Verileri context'e ekliyoruz.Bu şekilde eklemezsek db'ye eklenmez veriler.
            context.UyeFormu.AddRange(uyeFormu);
            context.Puanlama.AddRange(puanlama);
            context.KategoriTur.AddRange(kategoriTur);
            context.Kategori.AddRange(kategoriAdi);
            context.Restoran.AddRange(Restoran);
            context.Asci.AddRange(Asci);
            context.Odeme.AddRange(odeme);
            context.Siparise.AddRange(siparis);
            context.Tedarikci.AddRange(tedarikci);
            context.Malzeme.AddRange(malzeme);
            context.Tarif.AddRange(tarif);

            context.SaveChanges();
        }
    }
}
