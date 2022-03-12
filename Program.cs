using System;

namespace SwapTwoNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("please enter first number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter second number");
            int number2 = int.Parse(Console.ReadLine());
            int temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("After Swapping");
            Console.WriteLine("First number :" + number1);
            Console.WriteLine("Second number :" + number2);
        }
    }
}
