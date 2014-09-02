using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zouave.Domain.Users
{
    /// <summary>
    /// 加密方式
    /// </summary>
    public enum PwdFormat
    {
        [Description("Clear")]
        Clear = 0,
        [Description("Hashed")]
        Hashed = 1,
        [Description("Encrypted")]
        Encrypted = 2
    }
}
