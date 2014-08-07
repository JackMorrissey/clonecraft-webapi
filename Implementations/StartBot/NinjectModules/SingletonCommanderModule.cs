using CloneCraft.Interfaces;
using Ninject.Modules;

namespace CloneCraft.Implementations.StartBot.NinjectModules
{
    class SingletonCommanderModule: NinjectModule
    {
        public override void Load()
        {
            System.Diagnostics.Debug.WriteLine("Example NinjectModule ran!");
            Rebind<ICommander>().To<Commander>().InSingletonScope();
        }
    }
}
