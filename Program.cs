using System;

namespace lab1ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la tastatura.
             Numarul are exact 2 cifre*/

            int numar = int.Parse(Console.ReadLine());

            int suma = numar % 10 + numar / 10;
            Console.WriteLine(suma);
        }
    }
}
