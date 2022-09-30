using System;

namespace uppgfit
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            int timmar = int.Parse(Console.ReadLine());

            int kr = timmar * 80;
            

            if (kr < 950)
            {
                Console.WriteLine("Det kommer kosta " + kr +  " kr för dig attt hyra bilen");   
            }

            else
            {
                Console.WriteLine("Du har nått max priset 950 kr");
            }
        }
    }
}