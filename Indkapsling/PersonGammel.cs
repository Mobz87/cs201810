using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indkapsling
{
    class PersonGammel
    {

        private int alder;
        private string navn;

        public PersonGammel() : this(0 , "")
        {

        }

        public PersonGammel(int alder, string navn)
        {
            this.alder = alder;
            this.navn = navn;
        }

        public void SkrivNavn() {
            Console.WriteLine(this.navn);
        }

        public string NavnMedStore() {
            return this.navn.ToUpper();
        }

        public void SetNavn(string value) {
            // log
            // sikkerhed
            // validering
            if (value == null | value == "") {
                throw new ApplicationException("FORKERT ....");
            }
            this.navn = value;
        }
        public string GetNavn() {
            // log
            // sikkerhed
            // validering
            return this.navn;
        }

        public int GetAlder()
        {
            // log
            // sikkerhed
            // validering
            return this.alder;
        }

    }
}
