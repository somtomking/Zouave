using FluentValidation.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Zouave.Infrastructure;
using Zouave.Web.Framework;
using Zouave.Web.Framework.Mvc;

namespace Zouave.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //initialize engine context
            EngineContext.Initialize(false);

            //model binders
            ModelBinders.Binders.Add(typeof(BaseNopModel), new ZouaveModelBinder());

            //Add some functionality on top of the default ModelMetadataProvider
            ModelMetadataProviders.Current = new ZouaveMetadataProvider();

            AreaRegistration.RegisterAllAreas();


            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //fluent validation
            DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;
            ModelValidatorProviders.Providers.Add(new FluentValidationModelValidatorProvider(new ValidatorFactory()));

            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
        }
    }
}
