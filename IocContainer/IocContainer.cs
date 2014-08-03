using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Modules;

namespace CloneCraft.IocContainer
{
    public static class IocContainer
    {
        public static void BootStrap()
        {
            IKernel kernel = new StandardKernel();

            // Bind all 
            kernel.Bind(x => 
                x.FromAssembliesMatching("CloneCraft.*")
                .SelectAllClasses() // Retrieve all non-abstract classes
                .BindAllInterfaces()); //Bind all, if you have more than one, you'll have to rebind in a NinjectModule

            // Run all NinjectModules
            kernel.Load(kernel.GetAll<INinjectModule>());
        }
    }
}
