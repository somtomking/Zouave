using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zouave.Helper
{
    public static class CommonHelper
    {
        /// <summary>
        /// 根据用英文逗号连接的字符串动态强制转换成对应类型的只读集合
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="source">需要转换对应类型的字符串，多个用逗号分隔</param>
        /// <returns>只读集合</returns>
        public static ReadOnlyCollection<T> ParseTypeBySplitWithComma<T>(string source) where T : struct
        {
            Type t = typeof(T);
            bool isBasicValueType = t == typeof(byte) || t == typeof(short) || t == typeof(int) || t == typeof(long) || t == typeof(float) || t == typeof(double) || t == typeof(DateTime) || t == typeof(decimal);
            bool isGuidValueType = t == typeof(Guid);
            if (!(isBasicValueType || isGuidValueType))
            {
                throw new ArgumentException("泛型参数错误！只能是 byte、short、int、long、float、double、DateTime、decimal 这些基本类型或 Guid 类型。");
            }
            string[] sourceItems = source.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            List<T> result = new List<T>();
            if (isBasicValueType)
            {
                MethodInfo methodInfo = t.GetMethod("Parse", new Type[] { typeof(string) });
                foreach (string item in sourceItems)
                {
                    //T objT = Activator.CreateInstance<T>();   //也可以实例化，把这个实例化后的对象 传到 Invoke 方法的第一个参数
                    result.Add((T)methodInfo.Invoke(null /* 这里要求 T 类型的实例，由于是 Stuct 类型，所以不需要实例化 */, new object[] { item }));
                }
            }
            else if (isGuidValueType)
            {
                ConstructorInfo constructorInfo = t.GetConstructor(new Type[] { typeof(string) });
                foreach (string item in sourceItems)
                {
                    result.Add((T)constructorInfo.Invoke(new object[] { item }));
                }
            }
            return result.AsReadOnly();
        }
    }

}
