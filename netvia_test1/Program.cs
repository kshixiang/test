using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netvia_test1
{
    class Program
    {
        public static string Name
        {
            get;
            set;
            
        }
        static void Main(string[] args)
        {
        
            var data = new { test = "test", a = 10 };
            var data2 = new { test = "test2", a = 20 };
            data = data2;
            Name = "carl";
            Console.WriteLine(Name);
            Console.WriteLine(data.Equals(data2));
            Console.WriteLine(data.test);
            Test("test", 1, 2);
        }

        public static void Test(params Object[] data)
        {
            foreach(var item in data)
            {
                Console.WriteLine(item);
            }
            string a = "est";
            string b = "ok";
            Swap(ref a, ref b);
            Console.WriteLine(a + " " + b);
            Console.ReadKey();
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T tmp = a;
            a = b;
            b = tmp;
        }
    }
}
