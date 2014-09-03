using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zouave.Data.Repository.Users;
using Zouave.Domain;
using Zouave.Domain.Users;

namespace Zouave.Data.Configurations
{
    public class DependencyInjectionDataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
        }
    }
}
