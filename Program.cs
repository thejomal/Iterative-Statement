using System;

namespace Deliverable2_Iteration_Runowski
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please Enter an Integer between 2 and 20.");
            try
            {
                
                string input = Console.ReadLine();
                int x = int.Parse(input);
                int count = 1;
                if (x > 20 || x < 2)
                {
                    Console.WriteLine("Enter number between 2 and 20");
                }
                else
                {
                    while (count <= x)
                    {
                        Console.WriteLine("You have entered " + x + ". This is the current integer value in the loop: " + count);
                        count++; 
                    }
                }
            }
            catch
            {
                Console.ReadKey(true);
            }
        }
    }
}