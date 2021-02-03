using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStudy
{
    public class CommonMethod
    {

        /// <summary>
        /// int类型参数
        /// </summary>
        /// <param name="iparam"></param>
        public static void ShowInt(int iParam)
        {
            Console.WriteLine("ShwoInt方法 参数为：{0} 参数类型为：{1}", iParam, iParam.GetType());

        }


        /// <summary>
        /// string类型参数
        /// </summary>
        /// <param name="sparam"></param>
        public static void ShowString(string sParam)
        {
            Console.WriteLine("ShwoString方法 参数为：{0} 参数类型为：{1}", sParam, sParam.GetType());

        }

        /// <summary>
        /// DateTime类型参数
        /// </summary>
        /// <param name="dtParam"></param>
        public static void ShowDateTime(DateTime dtParam)
        {
            Console.WriteLine("ShwoDateTime方法 参数为：{0} 参数类型为：{1}", dtParam, dtParam.GetType());

        }

        /// <summary>
        /// Object类型参数装箱拆箱会有性能损耗
        /// </summary>
        /// <param name="obj"></param>
        public static void ShowObject(Object obj)
        {
            Console.WriteLine("ShowObject方法 参数为：{0} 参数类型为：{1}", obj, obj.GetType());
        }
    }
}
