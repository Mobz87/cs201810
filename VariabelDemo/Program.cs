using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariabelDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                int a;
                int b = 10;





                bool c;



                bool d = false;

                int e, f, g;

                byte h = 50;

                float y = Convert.ToSingle(0.44423);


                int dd = 132;
                double ffg = 394.24345;


                int U = 1;


                DateTime da = new DateTime(2018, 1, 1);
                Console.WriteLine(da);

                //checked
                //{
                byte r = 200;
                //r += 213;
                Console.WriteLine(r);
                //}

                TimeSpan ts = new TimeSpan(2, 1, 10, 30);


                string sss = "lkdf gdk gædslkjg ældskjf g";
                Console.WriteLine(sss);
                Console.WriteLine(sss.Length);

                string o = "ldfgdkjf";

                Console.WriteLine(o.ToUpper());


                string pp = " dlkfgædlk gslkdf\r\n \" \\dj kj dskj gf";
                Console.WriteLine(pp);

                string sti = @"c:\temp\test.txt";
                Console.WriteLine(sti);


                // Stopur
                //System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
                //s.Start();
                //string w = "";
                //for (int i = 0; i < 500000; i++)
                //{
                //    w += "*";
                //}
                //s.Stop();
                //Console.WriteLine($"ms = {s.ElapsedMilliseconds}");

                System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
                s.Start();

                System.Text.StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 50000000; i++)
                {
                    sb.Append("*");
                }
                s.Stop();
                Console.WriteLine($"ms = {s.ElapsedMilliseconds}");

                int q = 0;
                Console.WriteLine(q);



                string navn = null;
                Console.WriteLine(navn);

                Console.WriteLine(navn?.ToUpper());

                if (navn != null)
                {
                    Console.WriteLine(navn.ToUpper());
                }

                //Console.WriteLine("Indtast tal:");
                //string input = Console.ReadLine();
                //Console.WriteLine(input);
                //int tal = Convert.ToInt32(input);

                //tal++;
                //Console.WriteLine(tal);

                //int uuyt = System.Convert.ToInt32("10 c0");
                //Console.WriteLine(uuyt);

            }

            {

                int a = 1;
                double b = 323.2;
                string navn = "Mikkel";

            }
            {
                var a = 1;
                var b = 3434.34F;
                var c = "Mathias";
                var d = 'd';

                var f = new int[] { 4, 3, 1, 6, 4, 3, 2, 6 }; // int[]
                var g = f.GroupBy(i => i);          // IGrouping<int, int>

            }

            {
                DateTime? a = new DateTime(2017, 1, 1);
                if (a.HasValue)
                {
                    // ldkfjg lfd

                }

                if (a != null)
                {


                }

            }


            {
                const int antalMåneder = 12;
                

                string navn1 = "Mikkel";
                int alder1 = 15;
                //int køn1 = 0;        // 0 = dreng
                Køn køn1 = Køn.Dreng;

                string navn2 = "Lene";
                int alder2 = 51;
                //int køn2 = 1;       // 1 = pige
                Køn køn2 = Køn.Pige;
                Console.WriteLine((int)køn2);
                

                if (køn2 == Køn.Pige) { }

                DayOfWeek d = DayOfWeek.Saturday;

                switch (d)
                {
                    case DayOfWeek.Sunday:


                        break;
                    case DayOfWeek.Monday:



                        break;
                    case DayOfWeek.Tuesday:


                        break;
                    case DayOfWeek.Wednesday:
                        break;
                    case DayOfWeek.Thursday:
                        break;
                    case DayOfWeek.Friday:
                        break;
                    case DayOfWeek.Saturday:
                        break;
                    default:
                        break;
                }

            }

            {

                //int y = 0;
                //y++;

                Person p1 = new Person();
                p1.Alder = 12;
                p1.Navn = "Mathias";
                p1.Køn = Køn.Dreng;
                Console.WriteLine(p1.Navn);
                Console.WriteLine(p1.Alder);
                Console.WriteLine(p1.Køn);

                Person p2;/* = new Person();*/
                p2.Alder = 0;
                p2.Alder++;

                Person p3 = new Person();



                DateTime t = new DateTime(2018,1,1);

            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }


        }
    }

    class Hund { }
}
