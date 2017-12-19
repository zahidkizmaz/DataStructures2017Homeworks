/*
Zahid KIZMAZ
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {              
                Console.WriteLine("Press 0 for exiting the program. ");
                Console.Write("Use English Only!\nInput your text: ");
                string input = Console.ReadLine();
                Palindrome pl = new Palindrome(input);
                if (input.Equals("0"))
                {
                    Console.WriteLine("Good Bye!!!");
                    break;
                }
                if (pl.checkPalindrome())
                {
                    Console.WriteLine("This input is palindrome.!");
                }
                else
                    Console.WriteLine("This input is NOT palindrome.!");
                Console.WriteLine("------------------------------");               
            }
        }
    }
}
