using Ninject.Modules;

namespace CloneCraft.Commodore.NinjectModules
{
    public class SingletonCommodoreModule: NinjectModule
    {
        public override void Load()
        {
            Rebind<ICommodore>().To<Commodore>().InSingletonScope();
        }
    }
}
