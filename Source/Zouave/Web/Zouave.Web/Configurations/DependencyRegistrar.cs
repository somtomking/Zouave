using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zouave.Infrastructure.DependencyManagement;

namespace Zouave.Web.Configurations
{
    public class DependencyRegistrar : IDependencyRegistrar
    {

        public void Register(ContainerBuilder builder, Infrastructure.ITypeFinder typeFinder)
        {
            builder.RegisterControllers(System.Reflection.Assembly.GetExecutingAssembly());
        }

        public int Order
        {
            get { return 999; }
        }
    }
}