using System;

namespace QuotientAndRemainder
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=int.Parse(Console.ReadLine());
            Program.quotient(num);

            Program.remainder(num);
           
       
        }
        public static void quotient(int num)
        {
            int result = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    result = num / i;
                    Console.WriteLine(num+"/"+i+" quotient is= "+result);
                }
            }
            
        }
        public static void remainder(int num)
        {
            int result = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i != 0)
                {
                    result = num % i;
                    Console.WriteLine(num+"%"+i+" Remainder is= " + result);
                }
            }
        }
         

     

    }
}
