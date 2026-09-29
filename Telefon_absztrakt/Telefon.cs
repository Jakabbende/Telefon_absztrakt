using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_absztrakt
{
    public abstract class Telefon
    {
        public int Ar;
        public List<string> Tudja;

        protected Telefon(int ar, List<string> tudja)
        {
            this.Ar = ar;
            this.Tudja = tudja;
        }

        public bool Tud(string tudas)
        {
            return Tudja.Contains(tudas);
        }


    }
}
