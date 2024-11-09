using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Grupp
    {
        public String GrupiNimi { get; set; }
        public int GrupiSuurus { get; set; }
        public List<Liige> Liikmed = new List<Liige>();

        public Grupp(string grupiNimi, int grupiSuurus)
        {
            GrupiNimi = grupiNimi;
            GrupiSuurus = grupiSuurus;
        }

        public void LisaLiige(Liige liige)
        {
            if (Liikmed.Count < GrupiSuurus) {
                Liikmed.Add(liige);
            }
            else
            {
                Console.WriteLine("Grupp on täis");

            }
        }

        public void EemaldaLiige(Liige liige)
        {
            Liikmed.Remove(liige);
        }

        public void PrindiLiikmed()
        {
            foreach (Liige liige in Liikmed)
            {
                Console.WriteLine(liige.Nimi, liige.Email, liige.Isikukood);
            }
        }
    }
}
