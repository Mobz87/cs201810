using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indkapsling
{
    class Hund
    {
        private int antalBen;

        public int AntalBen
        {
            get { return antalBen; }
            set { antalBen = value; }
        }

        private string navn;

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }

        private int alder;

        public int Alder
        {
            get { return alder; }
            set { alder = value; }
        }

        public void Test1() { }

        public string Test2()
        {
            throw new System.NotImplementedException();
        }
    }
}
