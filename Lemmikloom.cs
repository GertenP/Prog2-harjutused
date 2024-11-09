using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Lemmikloom
    {
        public String LoomaNimi { get; }
        public String Loom { get; }

        public Persoon Omanik { get; set; }

        public Lemmikloom(String loomanimi, String loom)
        {
            LoomaNimi = loomanimi;
            Loom = loom;
        }

        public void GetLoomaInfo()
        {
            if (Omanik != null)
            {
            Console.WriteLine($"Nimi: {LoomaNimi}\nLoomaliik: {Loom}\nOmanik: {Omanik.Nimi}");

            } else
            {
                Console.WriteLine($"Nimi: {LoomaNimi}\nLoomaliik: {Loom}\nOmanik: Puudub");

            }
        }

        public override string ToString()
        {
            return $"{LoomaNimi}";
        }
    }
}
