using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogDemo
{
    class Program
    {

        private static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            log.Debug("App start");



            // hent fra db
            log.Trace("select * from ....");

            log.Debug("Kalder Test");
            Test(5);
            log.Debug("Retur fra Test");

            try
            {
                Test2();
            }
            catch (Exception ex)
            {
                // log...
                log.Error(ex);
                Console.WriteLine(ex.Message);
            }

            log.Debug("App slut");

        }

        static void Test(int a) {

            log.Debug("Enter " + a);

            // kode...

            log.Debug("Exit ");

        }

        static void Test2() {

            string h = null;
            h.ToUpper();
        }
    }
}
