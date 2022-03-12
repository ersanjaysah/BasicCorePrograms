using System;

namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter year");
            int year = int.Parse(Console.ReadLine());
            bool isleapyear = Class1.isLeapYear(year);
            Class1.isleap(isleapyear, year);
        }
    }
}
