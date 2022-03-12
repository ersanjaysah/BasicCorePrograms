using System;

namespace PowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number here");
            int num=int.Parse(Console.ReadLine());
            int value = PowerOf2(num);
            Console.WriteLine(value);    
        }
        public static int PowerOf2(int n)
        {
            int result = 1;
            while(n>0)
            {
                result = result * 2;
                n--;
            }
            return result;
        }
    }
}
