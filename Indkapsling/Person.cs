using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indkapsling
{
    class Person
    {
        public int Alder { get; private set; }
        public string Navn { get; set; }
        public string Land { get; set; }
        public bool KanEngelsk { get; set; }


        public void Test()
        {
            this.Alder = 10;

        }
   


    }
}
