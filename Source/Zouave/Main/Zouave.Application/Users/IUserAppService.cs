using Zouave.Dto.Users;
namespace Zouave.Application.Users
{
    public partial interface IUserAppService
    {
        /// <summary>
        /// 记录用户登录信息
        /// </summary>
        /// <param name="loginInfo"></param>
        void RecordLoginInfo(UserLoginInfoDto loginInfo);
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="registerRequest"></param>
        void RegisterUser(UserRegisterDto registerRequest);


        UserInfoDto GetById(object id);
    }
}
