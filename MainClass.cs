using System;

namespace Project1
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Sõnum class
            Sõnum tekst = new Sõnum();

            // Assigning values to the properties
            tekst.Sisu = "Väga suur sisu";
            tekst.Autor = "Gerten";
            tekst.Aeg = 50;
            tekst.MeeldimisteArv = 99;

            // Calling the meeldivus method
            tekst.Meeldivus();
        }
    }
}