using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Persoon
    {
        public String Eesnimi { get; }
        public String Perekonnanimi { get; }
        public String Nimi => $"{Eesnimi} {Perekonnanimi}";
        public List<Lemmikloom> Loomad = new List<Lemmikloom>();

        public Persoon(string eesnimi, string perekonnanimi)
        {
            Eesnimi = eesnimi;
            Perekonnanimi = perekonnanimi;
        }

        public void LisaLoom(Lemmikloom loom)
        {
            Loomad.Add(loom);
            loom.Omanik = this;
        }

        public void PrintLoomad()
        {
            Console.WriteLine($"{Nimi} omab järgmisi loomi: ");
            foreach (Lemmikloom loom in Loomad)
            {
                loom.GetLoomaInfo(); // See rida trükib välja iga looma info
            }
        }
    }

}

