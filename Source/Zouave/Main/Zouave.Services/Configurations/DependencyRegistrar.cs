using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zouave.Infrastructure.DependencyManagement;
using Zouave.Services.Installation;
using Zouave.Services.Installation.Impl;

namespace Zouave.Services.Configurations
{
    public class DependencyRegistrar : IDependencyRegistrar
    {


        public void Register(ContainerBuilder builder, Infrastructure.ITypeFinder typeFinder)
        {
            builder.RegisterType<InstallationFadeService>().As<IInstallationFadeService>().InstancePerLifetimeScope();
        }

        public int Order
        {
            get { return 11; }
        }
    }
}
