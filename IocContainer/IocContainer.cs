using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Modules;

namespace CloneCraft.IocContainer
{
    public static class IocContainer
    {
        private const string Assemblies = "CloneCraft.*";
        public static IKernel BootStrap()
        {
            var kernel = new StandardKernel(new NinjectSettings{LoadExtensions = false});
            
            // Bind all 
            kernel.Bind(x =>
                x.FromAssembliesMatching(Assemblies)
                .SelectAllClasses() // Retrieve all non-abstract classes
                .BindAllInterfaces() //Bind all, if you have more than one, you'll have to rebind in a NinjectModule
                .Configure(c => c.InTransientScope())); //If you want SingletonScope, rebind in a NinjectModule

            
            // Run all NinjectModules
            kernel.Load(Assemblies);
            
            return kernel;
        }
    }
}
