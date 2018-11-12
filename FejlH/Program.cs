using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FejlH
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Test(5);
                Console.WriteLine("*");
                Test(50);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                
            }


            //string fs = null;
            //fs.ToArray();


            try
            {
                int y = 10;
                string f = null;
                f.ToArray();
            }
            catch (Exception ex)
            {

                
                if (ex.InnerException != null) {
                    // log
                }
                // LOG.... ex

                Exception e = new ApplicationException("Kunden findes ikke", ex);
                

                throw e;
            }

            //try
            //{
            //    string j = null;
            //    Console.WriteLine(j.ToUpper());
            //}
            //catch(Exception ex)
            //{
            //    // Log....


            //    Console.WriteLine("FEJL " + ex.Message);
            //    return;
            //}

            //try
            //{
            //    string j = null;
            //    //Console.WriteLine(j.ToUpper());

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Fejl");

            //}
            //finally {
            //    Console.WriteLine("Kører altid");
            //}

            // Global fejlhåndtering
            try
            {
                F1();
            }
            catch (System.IO.FileNotFoundException ex) {

            }
            catch (Exception ex)
            {
                // LOG ... ex
                // System.IO.File.AppendAllText(@"c:\temp\log.txt", ex.Message);
                Console.WriteLine("Fejl");

            }
            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static void Test(int a) {

            // logik og validering
            if (a < 0 || a > 10) {
                Exception e = new ApplicationException("a er forkert...");
                throw e;
            }
            //


        }

        static void F1() {
            F2();
        }
        static void F2() {
            F3();
        }
        static void F3() {
            string g = null;
            g.ToUpper();
        }
    }
}
