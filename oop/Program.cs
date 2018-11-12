using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {


            Faktura f1 = new Faktura();
            f1.dato = DateTime.Now;
            f1.Skriv();

            Faktura f2 = new Faktura();
            f2.dato = new DateTime(2018, 1, 1);
            //f2.Skriv();

            bool v = f2.Valid();

            Faktura f3 = new Faktura(5);

            Bil b1 = new Bil();

            Bil b = new Bil(4);
            

        }
    }

    public class Person {
        private int Alder;

        public void Test() {
            Alder = 100;
        }
    }

    class Faktura {

        // Felter
        private int nummer;
        private double beløb;

        // Nej tak....
        public DateTime dato;

        // default constructor
        public Faktura()
        {
            // initialisering
            // validering
            // log
            // sikkerhed
            // if søndag
            //   throw new ApplicationException("Man må .....");

            this.nummer = 0;
            beløb = 100;
            dato = DateTime.Now;
        }

        // Custom constructor
        public Faktura(int n)
        {
            // validering
            this.nummer = n;
        }


            public void Skriv() {
            // kode
            Console.WriteLine($"Faktura {this.dato} ");
        }

        public bool Valid() {
            // kode
            return false;
        }


        public double MedMoms()
        {
            // kode
            return this.beløb * 1.25;
        }


    }

    class Bil {

        private int antalHjul;
        private int motorStørrelse;

        public Bil() : this(4,1000)
        {
            // log
        }

        public Bil(int antalHjul) : this(antalHjul, 1000)
        {
            // log
        }

        public Bil(int antalHjul, int motorStørrelse)
        {
            // log
            // sikkerhed
            // validering
            this.antalHjul = antalHjul;
            if (motorStørrelse < 850)
                throw new ApplicationException("Forkert motors");
            this.motorStørrelse = motorStørrelse;
        }


    }
}
