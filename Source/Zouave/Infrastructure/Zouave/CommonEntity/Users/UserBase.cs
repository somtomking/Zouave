using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zouave.CommonEntity.Users
{
    public partial class UserBase : Entity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
