using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Test();
            int res = LægSammen(2, 2);
            Console.WriteLine(res);


            int u = 10;
            int b = 20;
            int res2 = LægSammen(u, b);
            Console.WriteLine(res2);
            Console.WriteLine(u);

            Metode1("a", 10, true);

            Metode1(alder: 10, erSmart: true, land: "DK", navn: "a");
            Metode1(alder: 10, erSmart: true,  navn: "a");

            int res3 = LægSammen(5, 4, 32, 2);

            MinReturType res4 = TestF();

            var res5 = TestF1();

            int y = 0;


            

            Hund.Test1();

            Hund h = new Hund();
            h.Test2();


            PrintFiler("c:\\temp");
        }

        static void PrintFiler(string sti) {
            var filer = System.IO.Directory.GetFiles(sti);
            foreach (var fil in filer)
                Console.WriteLine(fil);
            var mapper = System.IO.Directory.GetDirectories(sti);
            foreach (var mappe in mapper)
                PrintFiler(mappe);
        }

        //static void Test5() {
        //    Test5();
        //}

        static MinReturType TestF()
        {
            MinReturType r;
            r.a = 10;
            r.b = 20;
            return r;
        }

        static (int a, int b, bool c) TestF1()
        {
            return (10, 20, true);
        }

        static void F1(int a) {
            // log
            F1(a, 1, 2);
        }
        static void F1(int a, int b) {
            // log
            F1(a, b, 1);
        }
        static void F1(int a, int b, int c) {


        }

        static void Metode1(string navn, int alder, bool erSmart, string land = "*")
        {
            Console.WriteLine(land);
        }


        static int LægSammen(int a, int b)
        {
            
            return a + b;
        }

        static int LægSammen(int a, int b, int c)
        {
            
            return a + b + c;
        }

        static int LægSammen(int a, int b, int c, int d)
        {

            return a + b + c + d;
        }

        private static void Test()
        {

        }

        // optional argumenter

        private static void Test1(int a)
        {

        }
        private static void Test2(int a, bool b)
        {

        }

        private static int Rumfang(int h, int b, int l)
        {
            return Areal(h, l) * b;

            int Areal(int hh, int ll)
            {
                return hh * ll;
            }

        }
    }

    struct MinReturType {
        public int a;
        public int b;
    }

    struct Hund {

        public static void Test1() {
            Console.WriteLine("Test1");
        }

        public void Test2() {
            Console.WriteLine("Test2");
        }
    }

}
