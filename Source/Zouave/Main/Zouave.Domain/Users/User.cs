using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zouave.Domain.Users
{
    public partial class User : BaseEntity
    {
        public User()
        {
            LoginInfos = new List<UserLoginInfo>();
        }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Pwd { get; set; }
        public PwdFormat PwdFormatType { get; set; }
        public string PwdSalt { get; set; }
        public bool IsSysAccount { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ActiveOn { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public string LastIpAddress { get; set; }
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 登录信息
        /// </summary>
        public virtual ICollection<UserLoginInfo> LoginInfos { get; set; }


    }

}
