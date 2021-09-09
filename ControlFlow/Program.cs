using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //Kui kasutaja on vanem, kui 18, siis konsoolis kuvatakse "Oled piisavalt vana"
            //Kui kasutaja on noorem kui 18, siis konsoolis kuvatakse "oled liiga noor"
            //kui kajutaja on 18, siis sa konsoolis kuvatake "oled 18."

            Console.WriteLine("Insert your age:");
            int Age = Convert.ToInt32(Console.ReadLine());
            if (Age > 18)
            {
                Console.WriteLine("You are old enough.");
                Console.ReadLine();

            }
            else if (Age < 18)
            {
                Console.WriteLine("You are too young.");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("You are 18 years old!");
                Console.ReadLine();

            }
            Console.WriteLine("Have a good day!");



        }
    }
}
