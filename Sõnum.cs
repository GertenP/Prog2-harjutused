using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Sõnum
    {
        public String Sisu { get; set; }
        public String Autor { get; set; }
        public int Aeg { get; set; }
        public int MeeldimisteArv { get; set; }

        public void Meeldivus()
        {
            int meeldivus = MeeldimisteArv / Aeg;
            Console.WriteLine($"Meeldivus sellel sõnumil on {meeldivus}");
        }

    }
}
