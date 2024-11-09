using System;

namespace Project1
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Persoon Gerten = new Persoon("Gerten", "Pilv");
            Lemmikloom Tobias = new Lemmikloom("Tobias", "Kass");

            Console.WriteLine(Tobias);
        }
    }
}