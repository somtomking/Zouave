using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Zouave
{ 
    /// <summary>
    /// 框架异常基类
    /// </summary>
    [Serializable]
    public class ZouaveException : Exception
    {
        public ZouaveException()
        {

        }
        public ZouaveException(string message)
            : base(message)
        { }
        public ZouaveException(string message, Exception inner)
            : base(message, inner) { }
        protected ZouaveException(
          SerializationInfo info,
          StreamingContext context)
            : base(info, context) { }
    }

}
