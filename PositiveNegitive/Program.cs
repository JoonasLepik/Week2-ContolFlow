using System;

namespace PositiveNegitive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there!");
            //programm palub kasutajal palub sisestada numbrit -10 kuni -10
            //programm kontrollib numbrit
            //kui number on +, koonsool kuvab "positive"
            //kui number on -, koonsool kuvab "negatiivne"
            //kui number on 0, konsool kuivab "0"

            Console.WriteLine("Please enter a number between -10 and 10.");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number > 0)
            {
                Console.WriteLine("It's Positive.");

            }
            else if (Number < 0)
            {
                Console.WriteLine("It's Negitive");
            }
            else
            {
                Console.WriteLine("Zero");
            }
            Console.WriteLine("Have a good day!");
            Console.ReadLine();
        } 
    }
}
