using Autofac;
using Zouave.Application.Installation;
using Zouave.Application.Installation.Impl;
using Zouave.Infrastructure.DependencyManagement;
 

namespace Zouave.Application.Configurations
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
