using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("How many loops?  ");
            int userT;
            while (!int.TryParse(Console.ReadLine(), out userT))
            {
                Console.WriteLine("You must enter a number!  Try again.");
            }    
            for (int t = userT; t > 0; t--)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine("Hello " + name + "!");
        }
    }
}
