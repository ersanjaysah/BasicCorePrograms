using System;

namespace EvenAndOddNumber
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("please enter the number");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine(" This is a Even number");
            }
            else
            {
                Console.WriteLine("This is an odd number");
            }
       

        }

    }
}
