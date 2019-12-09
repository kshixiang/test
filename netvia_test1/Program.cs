using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace netvia_test1
{
    //estfsdfsfsdf
    public sealed class TestIndex
    {
        public int[] testData = new int[32];

        [IndexerName("num")]
        public int this[Int32 index, Int32 index2,Int32 index3]
        {
            get
            {
                return testData[index];
            }
            set
            {
                testData[index] = value;
            }


        }

 
    }
    class Program
    {

        public readonly string m_data;
        public static string Name
        {
            get;
            set;
            
        }
        static void Main(string[] args)
        {
            var ak = new TestIndex();
            ak[0,1,0] = 10;
            Console.WriteLine(ak[0,1,0]);
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
