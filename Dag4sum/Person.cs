using System;

namespace Dag4sum
{
    public partial class Person
    {

        // felter
        private int _alder;
        private string _navn;
        private string _land;

        public static double moms;

        // Default
        public Person() : this(0, "", "")
        {
        }

        // Custom
        public Person(int alder, string navn, string land)
        {
            // log
            // sikkerhed
            // validering
            // ....
            this._alder = alder;
            this._navn = navn;
            this._land = land;
        }

        public void Test1()
        {
            Console.WriteLine("I Test1 " + this._alder);
        }

        public static void Test2()
        {
            Console.WriteLine("I Test2 ");
        }

    }
}
