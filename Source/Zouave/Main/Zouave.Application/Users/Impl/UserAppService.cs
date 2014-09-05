using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Zouave.Application.Users;
using Zouave.Dto.Users;

namespace Zouave.Application.Users.Impl
{
    public partial class UserFacadeService : AppServiceBase, IUserAppService
    {
        public void RecordLoginInfo(UserLoginInfoDto loginInfo)
        {

        }

        public void RegisterUser(UserRegisterDto registerRequest)
        {

        }

        public UserInfoDto GetById(object id)
        {
            return null;
        }
    }
}
