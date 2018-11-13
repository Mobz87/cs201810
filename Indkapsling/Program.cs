using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCronberg;

namespace Indkapsling
{
    class Program
    {
        static void Main(string[] args)
        {

            //PersonGammel p1 = new PersonGammel(12, "Mathias");
            //p1.SkrivNavn();
            //string n = p1.NavnMedStore();
            //Console.WriteLine(n);

            //p1.SetNavn("Mathias A");

            ////p1.Navn = "Mikkel";

            //Console.WriteLine(p1.GetNavn());


            //Console.WriteLine(p1.GetAlder());


            //PersonFuldEgenskab p1 = new PersonFuldEgenskab();
            //p1.Alder = 12;
            //p1.Navn = "Mathias";
            //Console.WriteLine(p1.Alder);
            //Console.WriteLine(p1.Navn);

            //Console.WriteLine(p1.ToStringEx());

            //// Reflection C#

            //var metoder = p1.GetType().GetMethods();
            //var egenskaber = p1.GetType().GetProperties();


            Person p1 = new Person()
            {
                Navn = "a",
                KanEngelsk = true
            };

            Console.WriteLine(p1.ToStringEx());

        }
    }
}
