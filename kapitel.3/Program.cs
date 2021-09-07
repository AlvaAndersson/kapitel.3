using System;

namespace kapitel._3
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine()); 

            if (age < 50)

            {
                Console.WriteLine("You are too young to compete");
            }

            if (age >=50)
            {
                Console.WriteLine("You can compete in the golf tournement."); 
            }
        }
    }
}
