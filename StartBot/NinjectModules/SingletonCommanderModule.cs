using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloneCraft.Interfaces;
using Ninject.Modules;

namespace CloneCraft.StartBot.NinjectModules
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
