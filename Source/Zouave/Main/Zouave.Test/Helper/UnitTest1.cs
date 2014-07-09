using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zouave.Helper;

namespace Zouave.Test.Helper
{
    [TestClass]
    public class PinyinHelperTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = PinyinHelper.Convert("您好啊~");
            
        }
    }
}
