using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zouave.Infrastructure.DependencyManagement;

namespace Zouave.Services.Configurations
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        

        public void Register(ContainerBuilder builder, Infrastructure.ITypeFinder typeFinder)
        {
            
        }

        public int Order
        {
            get { return 2; }
        }
    }
}
