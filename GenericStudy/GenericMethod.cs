using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStudy
{
    public class GenericMethod
    {
        /// <summary>
        /// 泛型方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tParam"></param>
        public static void Show<T>(T tParam)
        {
            Console.WriteLine("Show<T>方法 参数为：{0} 参数类型为：{1}", tParam, tParam.GetType());
        }

        /// <summary>
        /// Object类型参数
        /// </summary>
        /// <param name="obj"></param>
        public static void ShowObject(Object obj)
        {
            Console.WriteLine("ShowObject方法 参数为：{0} 参数类型为：{1}", obj, obj.GetType());
        }
    }
}
