using System;

namespace GreatestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            int num3 = int.Parse(Console.ReadLine());

            Program.greatestNumber(num1, num2, num3);

        }
        public static void greatestNumber(int num1, int num2, int num3)
        {
            if(num1>num2 || num1>num3)
            {
                Console.WriteLine(num1+" is greater");
            }
            else if (num2>num3)
            {
                Console.WriteLine(num2+" is greater");
            }
            else
            {
                Console.WriteLine(num3+" is greater");
            }
        }
    }
}
