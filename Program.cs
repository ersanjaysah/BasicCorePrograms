using System;

namespace VowelAndConsonent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=(Console.ReadLine());
            char alphabet=Convert.ToChar(input.ToUpper());
            switch(alphabet)
            {
                case 'A':
                    Console.WriteLine("vowel");
                    break;

                case 'E':
                    Console.WriteLine("vowel");
                    break;

                case 'I':
                    Console.WriteLine("vowel");
                    break;

                case 'O':
                    Console.WriteLine("vowel");
                    break;

                case 'U':
                    Console.WriteLine("vowel");
                    break;

                default:
                    Console.WriteLine("consonent");
                    break;

            }
        }
    }
}
