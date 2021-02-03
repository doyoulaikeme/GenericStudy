using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStudy
{
    /// <summary>
    /// 泛型缓存,同一个类型只有首次生成，后面直接调用。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericCache<T>
    {
        private static string CacheData = null;

        /// <summary>
        /// 静态构造函数
        /// </summary>
        static GenericCache()
        {
            CacheData = string.Format("{0}_{1:yyyy-MM-dd HH:mm:ss fff}", typeof(T).FullName, DateTime.Now);
        }

        public static string GetData()
        {
            return CacheData;
        }

    }

    public class GenericCacheTest
    {
        public void Show()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("*********GenericCacheTest*********");
                Console.WriteLine(GenericCache<int>.GetData());
                Console.WriteLine(GenericCache<string>.GetData());
                Console.WriteLine(GenericCache<DateTime>.GetData());
                Console.WriteLine(GenericCache<object>.GetData());
            }
        }
    }
}
