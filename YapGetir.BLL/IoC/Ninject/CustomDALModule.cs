using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetir.DAL.Abstract;
using YapGetir.DAL.Concrete;

namespace YapGetir.BLL.IoC.Ninject
{
    public class CustomDALModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IAsciDAL>().To<AsciRepository>();
            Bind<IKampanyaDAL>().To<KampanyaRepository>();
            Bind<IKategoriDAL>().To<KategoriRepository>();
            Bind<IKategoriTurDAL>().To<KategoriTurRepository>();
            Bind<IMalzemeDAL>().To<MalzemeRepository>();
            Bind<IOdemeDAL>().To<OdemeRepository>();
            Bind<IPaylasmaDAL>().To<PaylasmaRepository>();
            Bind<IPuanlamaDAL>().To<PuanlamaRepository>();
            Bind<IRestoranDAL>().To<RestoranRepository>();
            Bind<ISiparisDAL>().To<SiparisRepository>();
            Bind<ITarifDAL>().To<TarifRepository>();
            Bind<ITedarikciDAL>().To<TedarikciRepository>();
            Bind<IUrunDAL>().To<UrunRepository>();
            Bind<IUyeFormuDAL>().To<UyeFormuRepository>();
            Bind<IUyeTipDAL>().To<UyeTipRepository>();
            Bind<IYorumDAL>().To<YorumRepository>();

        }
    }
}
