using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastReflectionLib;
using System.Reflection;
namespace Zouave.Helper
{
    public static class ReflectionHelper
    {
        public static object GetPropertyValue(Type t, object obj, string propertyName)
        {
            var p = t.GetProperty(propertyName);
            return p.FastGetValue(obj);
        }
        public static void SetPropertyValue(Type t, object obj, object val, string propertyName)
        {
            var p = t.GetProperty(propertyName);
            p.FastSetValue(obj, val);
        }
        public static object GetPropertyValue<T>(T t, string propertyName)
        {
            var type = typeof(T);
            return GetPropertyValue(type, propertyName);
        }

        public static void SetPropertyValue<T>(T t, object val, string propertyName)
        {
            var type = typeof(T);
            SetPropertyValue(type, val, propertyName);
        }

        /// <summary>
        /// 克隆对象
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dest"></param>
        public static void ReflectClone(object source, object dest)
        {
            PropertyInfo[] properties = source.GetType().GetProperties();
            foreach (PropertyInfo item in properties)
            {
                PropertyInfo property = dest.GetType().GetProperty(item.Name);
                try
                {
                    property.FastSetValue(dest, item.FastGetValue(source));
                }
                catch
                {

                }
            }
        }

        public static void Clone(this object source, object desc)
        {
            ReflectionHelper.ReflectClone(source, desc);
        }
    }
}
