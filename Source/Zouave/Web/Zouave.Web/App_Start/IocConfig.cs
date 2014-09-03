using Autofac;
using Autofac.Features.ResolveAnything;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zouave.Data.Configurations;
using Zouave.Services.Configurations;
using Zouave.Web.Configurations;

namespace Zouave.Web.App_Start
{
    public class IocConfig
    {

        public static void ConfigureDependency()
        {
            var builder = new ContainerBuilder();
            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());
            builder.RegisterModule(new DependencyInjectionDataModule());
            builder.RegisterModule(new DependencyInjectionServiceModule());
            builder.RegisterModule(new DependencyInjectionMvcModule());

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}