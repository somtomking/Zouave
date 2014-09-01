using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zouave.Extendsions
{
    public static class StringExtendsion
    {
        /// <summary>
        /// 对字符串扩展，对String.Format的封装
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string F(this string format, params string[] args)
        {
            return string.Format(format, args);
        }
    }
}
