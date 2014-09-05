using AutoMapper;
using Zouave.Domain.Configuration;
using Zouave.Dto.Configuration;
using Zouave.Infrastructure;
namespace Zouave.Application.Configurations
{
    public partial class ObjectMapConfigStartupTask : IStartupTask
    {

        public void Execute()
        {
            Mapper.CreateMap<Setting, SettingDto>();
            
        }

        public int Order
        {
            get { return 0; }
        }
    }
}
