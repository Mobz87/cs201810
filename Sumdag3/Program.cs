using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumdag3
{
    class Program
    {
        static void Main(string[] args)
        {


            int i = 10;


            double y = 0;
            y++;

            DateTime f = DateTime.Now;
            DateTime f2 = new DateTime(2018, 1, 1);
            TimeSpan ts = f - f2;
            Console.WriteLine(ts.TotalDays);
            Console.WriteLine(f);


            Person p;
            p.Navn = "Mikkel";

            p.Køn = Køn.Mand;

            Console.WriteLine(Convert.ToInt32(p.Køn));

            Køn k = Køn.Kvinde;
            switch (k)
            {
                case Køn.Mand:

                    break;
                case Køn.Kvinde:
                    break;
                default:
                    break;
            }

            Test1(4);
            Person p2 = Test4(5);


            string temp = "1 " + " 2" + "3";
            string v1 = "z";
            double g = 3494.345;
            temp = $"{v1} {v1} = sldkfjsd l {v1} ... {g:N2}";


            

            Console.ReadKey();


        }

        static void Test() {
            Console.WriteLine("Test");
        }

        static void Test(int y)
        {
            Console.WriteLine("Test");
        }

        static void Test(long o)
        {
            Console.WriteLine("Test");
        }

        static void Test1(int a)
        {
            a = 10;
            Console.WriteLine("Test1 " + a);
        }

        static void Test2(int a, bool b)
        {
            a = 10;
            Console.WriteLine("Test1 " + a);
        }

        static bool Test3(int a)
        {
            if (a < 10)
                return true;
            else
                return false;
        }

        static Person Test4(int a)
        {
            // db
            Person p = new Person();
            p.Navn = "a";
            return p;
        }

        static (int, bool) Test5()
        {
            // db
            return (1, true);

        }


    }
}
