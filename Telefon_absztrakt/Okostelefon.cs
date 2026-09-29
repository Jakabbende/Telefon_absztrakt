using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_absztrakt
{
    internal class Okostelefon : Normaltelefon
    {
        public string Os;

        public Okostelefon(int ar, List<string> tudja, int maxtoltottseg, int aktualistoltottseg, string Os) : base(ar, tudja, maxtoltottseg, aktualistoltottseg)
        {
            this.Os = Os;
            this.Tudja.Add("Internet");
        }

        public bool Telepitheto(string Os)
        {
            return this.Os.Equals(Os);
        }
    }
}
