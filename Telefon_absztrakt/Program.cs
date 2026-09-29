using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_absztrakt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefon t1 = new Normaltelefon(15, new List<string>() { "Hívás", "SMS"},100,67);
            
            Console.WriteLine(t1.Ar + "Ft, " + String.Join(", ", t1.Tudja) + ", " + ((Normaltelefon)t1).Meddigbirja() + "%");
            Console.WriteLine(t1.Tud("SMS")? "Tud sms-t" : "Nem tud sms-ezni");



            Okostelefon ot = new Okostelefon(122222, new List<string>() { "Hívás", "SMS", "Bluetooth", "Wifi" }, 2000, 1400, "Ifos");

            Console.WriteLine(ot.Ar + "Ft, " + String.Join(", ", ot.Tudja) + ", " + ot.Meddigbirja() + "%");
            Console.WriteLine(ot.Telepitheto("Andi")? "Igen telepíthető" : "Nem telepíthető");
        }
    }
}
