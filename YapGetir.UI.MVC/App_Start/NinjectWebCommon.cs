[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(YapGetir.UI.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(YapGetir.UI.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace YapGetir.UI.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using YapGetir.BLL.Abstract;
    using YapGetir.BLL.Concrete;
    using YapGetir.BLL.IoC.Ninject;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IAsciService>().To<AsciService>();
            kernel.Bind<IKampanyaService>().To<KampanyaService>();
            kernel.Bind<IKategoriService>().To<KategoriService>();
            kernel.Bind<IKategoriTurService>().To<KategoriTurService>();
            kernel.Bind<IMalzemeService>().To<MalzemeService>();
            kernel.Bind<IOdemeService>().To<OdemeService>();
            kernel.Bind<IPaylasmaService>().To<PaylasmaService>();
            kernel.Bind<IPuanlamaService>().To<PuanlamaService>();
            kernel.Bind<IRestoranService>().To<RestoranService>();
            kernel.Bind<ISiparisService>().To<SiparisService>();
            kernel.Bind<ITarifService>().To<TarifService>();
            kernel.Bind<ITedarikciService>().To<TedarikciService>();
            kernel.Bind<IUrunService>().To<UrunService>();
            kernel.Bind<IUyeFormuService>().To<UyeFormuService>();
            kernel.Bind<IUyeTipService>().To<UyeTipService>();
            kernel.Bind<IYorumService>().To<YorumService>();
            kernel.Load<CustomDALModule >();
        }        
    }
}
