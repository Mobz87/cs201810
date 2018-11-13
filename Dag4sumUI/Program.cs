using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag4sumUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UI");

            Dag4sum.Person p1 = new Dag4sum.Person();
            Dag4sum.Person p2 = new Dag4sum.Person(10, "Mathias", "DK");

            int i = 0;

            // Instansen
            // i.ToString()

            // Typen
            // int.Parse

            p1.Test1();            
            p2.Test1();

            Dag4sum.Person.Test2();
            Dag4sum.Person.moms = 0.25;


        }
    }
}
