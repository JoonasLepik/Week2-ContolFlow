using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programm küsib kasutaja sünniaastat
            // programm kontrollib kasutaja vanust
            // programm teatab kasutajat, kas ta on piisavalt vana,
            // et juhiluba saada (tingimuseks 18 aastat vana)

            Console.WriteLine("What year were you born?");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int Age = 2021 - YearOfBirth;
            if (Age >= 18)
            {
                Console.WriteLine($"You are {Age} years old, you are old enough to get your car license.");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine($"You are {Age} years old, you are not old enough to get your car license. ");
                Console.ReadLine();
            }
            
            Console.WriteLine("Have a good day!");
            Console.ReadLine();

            
        }

    }
}
