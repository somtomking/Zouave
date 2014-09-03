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
            //data layer
            var dataSettingsManager = new DataSettingsManager();
            var dataProviderSettings = dataSettingsManager.LoadSettings();
            builder.Register(c => dataSettingsManager.LoadSettings()).As<DataSettings>();
            builder.Register(x => new EfDataProviderManager(x.Resolve<DataSettings>())).As<BaseDataProviderManager>().InstancePerDependency();
            builder.Register(x => x.Resolve<BaseDataProviderManager>().LoadDataProvider()).As<IDataProvider>().InstancePerDependency();

            if (dataProviderSettings != null && dataProviderSettings.IsValid())
            {
                var efDataProviderManager = new EfDataProviderManager(dataSettingsManager.LoadSettings());
                var dataProvider = efDataProviderManager.LoadDataProvider();
                dataProvider.InitConnectionFactory();

                builder.Register<IDbContext>(c => new ZouaveObjContext(dataProviderSettings.DataConnectionString)).InstancePerLifetimeScope();
            }
            else
            {
                builder.Register<IDbContext>(c => new ZouaveObjContext(dataSettingsManager.LoadSettings().DataConnectionString)).InstancePerLifetimeScope();
            }
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

            builder.RegisterType<UserRepository>().As<IUserRepository>();
        }

        public int Order
        {
            get { return 10; }
        }
    }
}
