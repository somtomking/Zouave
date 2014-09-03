using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zouave.Infrastructure;
using Zouave.Infrastructure.DependencyManagement;
using Zouave.Web.Infrastructure.Installation;

namespace Zouave.Web.Configurations
{
    public class DependencyRegistrar : IDependencyRegistrar
    {

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
           
           
        }

        public int Order
        {
            get { return 999; }
        }
    }
}