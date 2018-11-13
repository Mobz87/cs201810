using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indkapsling
{
    public class PersonFuldEgenskab
    {
        
        private int _alder;
        private string _navn;

        public int Alder {
            get {
                // sikkerhed
                // log 
                // valider
                return this._alder;
            }
            set {
                // implicit value
                // sikkerhed
                // log 
                // valider
                if (value < 0 || value > 110) {
                    throw new ApplicationException("Forkert alder");
                }
                this._alder = value;
            }
        }

        public string Navn
        {
            get
            {
                // sikkerhed
                // log 
                // valider
                return this._navn;
            }
            set
            {
                // implicit value
                // sikkerhed
                // log 
                // valider                
                this._navn = value;
            }
        }

        private bool godTilEngelsk;

        public bool GodTilEngelsk
        {
            get { return godTilEngelsk; }
            set { godTilEngelsk = value; }
        }

        private DateTime dateTime;
        public DateTime Fødselsdato
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        public void Test() { }

        //public string land;
        private string land;

        public string Land
        {
            get
            {
                return land;
            }

            set
            {               
                land = value;
            }
        }


    }
}
