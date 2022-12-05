using System;

namespace lab2ex1
{
    /*: Scrieti un program care va afisa suma cifrelor unui numar n, 
        n fiind citit de la tastatura.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;

            while (n != 0)
            {
                suma = suma + n % 10;
                n = n / 10;

            }

            Console.WriteLine($"Suma cifrelor este: {suma}");
        }
    }
}
