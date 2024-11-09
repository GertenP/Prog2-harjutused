using System;

namespace Project1
{
    public class Liige
    {
        public string Eesnimi { get; set; }
        public string Perekonnanimi { get; set; }
        public string Nimi => $"{Eesnimi} {Perekonnanimi}";
        public string Isikukood { get; set; }
        public string Email { get; set; }

        public Liige(string eesnimi, string perekonnanimi, string isikukood, string email)
        {
            Eesnimi = eesnimi;
            Perekonnanimi = perekonnanimi;
            Isikukood = isikukood;
            Email = email;
        }

        public bool IsikukoodiKontroll()
        {
            if (Isikukood.Length != 11 || !long.TryParse(Isikukood, out _))
            {
                Console.WriteLine("Isikukood on vale pikkusega või sisaldab mitte-numbreid");
                return false;
            }

            int sugu = int.Parse(Isikukood.Substring(0, 1));
            if (sugu < 1 || sugu > 6)
            {
                Console.WriteLine("Isikukoodi sugu on vale");
                return false;
            }

            int year = (sugu <= 2) ? 1800 : (sugu <= 4) ? 1900 : 2000;
            year += int.Parse(Isikukood.Substring(1, 2));
            int month = int.Parse(Isikukood.Substring(3, 2));
            int day = int.Parse(Isikukood.Substring(5, 2));

            if (!IsValidDate(year, month, day))
            {
                Console.WriteLine("Isikukoodi sünnikuupäev on vigane");
                return false;
            }

            int checkDigit = int.Parse(Isikukood.Substring(10, 1));
            if (checkDigit != CalculateCheckDigit(Isikukood))
            {
                Console.WriteLine("Isikukoodi kontrollnumber on vale");
                return false;
            }

            Console.WriteLine("Isikukood on õige");
            return true;
        }

        private bool IsValidDate(int year, int month, int day)
        {
            try
            {
                DateTime birthDate = new DateTime(year, month, day);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private int CalculateCheckDigit(string isikukood)
        {
            int[] weights1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            int[] weights2 = { 3, 4, 5, 6, 7, 8, 9, 1, 2, 3 };

            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += (isikukood[i] - '0') * weights1[i];
            }

            int checkDigit = sum % 11;
            if (checkDigit == 10)
            {
                sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum += (isikukood[i] - '0') * weights2[i];
                }
                checkDigit = sum % 11;
                if (checkDigit == 10)
                {
                    checkDigit = 0;
                }
            }

            return checkDigit;
        }
    }
}
