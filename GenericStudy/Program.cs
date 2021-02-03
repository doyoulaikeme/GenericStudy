using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int iVal = 1;
            string sVal = "a";
            DateTime dateTime = DateTime.Now;
            object oVal = "object";
            #region 基本调用

            Console.WriteLine("*********正常调用************");
            CommonMethod.ShowInt(iVal);
            CommonMethod.ShowString(sVal);
            CommonMethod.ShowDateTime(dateTime);

            //Object类型是一切类型的父类
            //任何父类出现的地方都可以用子类代替
            Console.WriteLine("*********Object调用************");
            CommonMethod.ShowObject(iVal);
            CommonMethod.ShowObject(sVal);
            CommonMethod.ShowObject(dateTime);
            CommonMethod.ShowObject(oVal);

            //泛型调用一般要求制定参数类型，除非可以推算，否则参数必须和参数类型一致。
            Console.WriteLine("*********Generic调用************");
            GenericMethod.Show(iVal);
            GenericMethod.Show(sVal);
            GenericMethod.Show(dateTime);
            GenericMethod.Show(oVal);

            new GenericCacheTest().Show();
            #endregion



            Console.ReadKey();
        }


    }
}
