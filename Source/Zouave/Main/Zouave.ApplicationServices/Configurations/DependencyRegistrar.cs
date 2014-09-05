using Autofac;
using Zouave.ApplicationServices.Installation;
using Zouave.ApplicationServices.Installation.Impl;
using Zouave.Infrastructure.DependencyManagement;
 

namespace Zouave.ApplicationServices.Configurations
{
    public class DependencyRegistrar : IDependencyRegistrar
    {


        public void Register(ContainerBuilder builder, Infrastructure.ITypeFinder typeFinder)
        {
            
            builder.RegisterType<InstallationAppService>().As<IInstallationAppService>().InstancePerLifetimeScope();
            
        }

        public int Order
        {
            get { return 11; }
        }
    }
}
