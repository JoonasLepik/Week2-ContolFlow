using System;

namespace WhenWereYouBorn
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programm küsib kasutaja sünniaastat
            // Program arvutab kasutaja vanust
            // Program kuvab kasutaja vanuse

            Console.WriteLine("When were you born?");
            int Yearofbirth = Convert.ToInt32(Console.ReadLine());
            int Age = 2021 - Yearofbirth;

            Console.WriteLine($"You are {Age} years old.");
            Console.ReadLine();
        }
    }
}
   