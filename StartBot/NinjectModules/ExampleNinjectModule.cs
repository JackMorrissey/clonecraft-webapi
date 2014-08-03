using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace CloneCraft.StartBot.NinjectModules
{
    class ExampleNinjectModule: NinjectModule
    {
        public override void Load()
        {
            System.Diagnostics.Debug.WriteLine("Example NinjectModule ran!");
        }
    }
}
