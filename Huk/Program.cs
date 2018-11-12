using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huk
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 10;
            int x = 20;
            i = x;
            x = 30;


            Person p1 = new Person();
            p1.navn = "a";
            p1.alder = 10;

            Person p2 = new Person();
            p2.navn = "b";
            p2.alder = 20;

            p1 = p2;
            p2.alder = 100;

            Person p3;

            p3 = p2;


            Person q = new Person() { navn = "x", alder = 10 };
            //Person qq = new Person();
            //qq.alder = q.alder;
            //qq.navn = q.navn;
            
            Console.WriteLine(q.alder);
            Test(ref q);
            Console.WriteLine(q.alder);

            int y = 20;
            TestInt(ref y);
            Console.WriteLine(y);

        }

        static void TestInt(ref int a) {
            a = 100;
        }

        static void Test(ref Person t) {
            //t.alder = 20;
            t = new Person();
            t.alder = 90;
        }



    }

    class Person {
        public string navn;
        public int alder;
    }

    class Hund { }
}
