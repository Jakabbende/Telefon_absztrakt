using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_absztrakt
{
    public class Normaltelefon : Telefon
    {
        public int maxtoltottseg;
        public int aktualistoltottseg;
        public Normaltelefon(int ar, List<string> tudja, int maxtoltottseg, int aktualistoltottseg) : base(ar, tudja)
        {
            this.maxtoltottseg = maxtoltottseg;
            this.aktualistoltottseg = aktualistoltottseg;
        }

        public int Meddigbirja() { return (int)(((double)aktualistoltottseg) / maxtoltottseg * 100); }

    }
}
