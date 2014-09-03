using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zouave.Data.Repository.Users;
using Zouave.Domain;
using Zouave.Domain.Users;
using Zouave.Infrastructure.DependencyManagement;

namespace Zouave.Data.Configurations
{
    public class DependencyRegistrar : IDependencyRegistrar
    {


        public void Register(ContainerBuilder builder, Infrastructure.ITypeFinder typeFinder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
        }

        public int Order
        {
            get { return 0; }
        }
    }
}
