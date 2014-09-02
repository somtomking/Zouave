using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zouave.Domain.Users
{
    public class UserLoginInfo : BaseEntity
    {
        public DateTime LoginTime { get; set; }
        public string IpAddress { get; set; }
    }
}
