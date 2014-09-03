using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zouave.Domain.Users;

namespace Zouave.Data.Mapping.Users
{
    public class UserLoginInfoMap : EntityTypeConfiguration<UserLoginInfo>
    {
        public UserLoginInfoMap()
        {
            this.ToTable("Sys_UserLoginInfo");

            this.HasRequired(p=>p.User).WithMany(p=>p.LoginInfos).HasForeignKey(p=>p.UserId);
        }
    }
}
