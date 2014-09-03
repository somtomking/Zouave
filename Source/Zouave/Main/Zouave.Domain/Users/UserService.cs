using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zouave.Domain.Users.Service
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public virtual void ChangePassword(User user, string oldPwd, string newPwd)
        {

        }
        public virtual void TestUser(string email, string pwd)
        {
            var user = _userRepository.Create();
            user.Email = email;
            user.Pwd = pwd;
            user.CreateOn = DateTime.Now;
            user.Guid = Guid.NewGuid();
            user.IsSysAccount = true;
            user.Name = email;
            user.PwdFormatType = PwdFormat.Clear;

            _userRepository.Insert(user);

        }
    }
}
