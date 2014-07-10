using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zouave.Helper
{
    public static class EnvironmentHelper
    {
        /// <summary>
        /// 获取当前程序占用的内存大小(兆)
        /// </summary>
        /// <returns></returns>
        public static long GetCurrentMemorySize()
        {
            var result = Process.GetCurrentProcess().PrivateMemorySize64 / 1024 / 1024;
            return result;
        }
    }
}
