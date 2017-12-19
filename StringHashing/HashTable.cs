/*
Zahid KIZMAZ 
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SH
{
    class HashTable
    {
        string[] rows;
        string[] input;
        int count;
        int collisionCount;
        List<int> effort;

        public HashTable(string[] input)
        {
            rows = new string[11443];
            count = 0;
            effort = new List<int>();
            this.input = input;         
        }

        public void Hash()
        {
            foreach (string item in input)
                insertElement(item);
        }

        public int hash1(string value)
        {
            int h = 13;
            for (int i = 0; i < value.Length; i++)
            {
                h = (h * 31 + value[i]);
            }
            return Math.Abs(h);
        }
        public int hash2(string value)
        {
            int h = 0;
            for (int i = 0; i < value.Length; i++)
            {
                h +=value[i] * findNextPrime(i);
            }
            return Math.Abs(h);
        }

        public bool isPrime(int number)
        {
            for (int i = 2; i < number; i++)
                if (number % i == 0)
                    return false;
            return true;
        }

        public int hashMethod(string val,int i)
        { return (hash1(val) + i * hash2(val)) % rows.Length;}

        public void insertElement(string val)
        {
            int i = 0;
            while (true)
            {
                int pos = hashMethod(val,i);
                if (rows[pos] == null)
                {
                    rows[pos] = val;
                    this.count++;
                    effort.Add(i);
                    return;
                }
                else
                {
                    collisionCount++;
                }
                i++;
            }             
        }

        public int findNextPrime(int number)
        {
            while (!isPrime(number)) number++;
            return number;
        }

        public void displayStatistics()
        {
            Console.WriteLine("Stored element count: " + count);
            Console.WriteLine();
            Console.WriteLine("Unsuccessful to store element count: " + (input.Length - count));
            Console.WriteLine();
            Console.WriteLine("Maximum of steps while storing elements, max(i): " + effort.Max());
            Console.WriteLine();
            Console.WriteLine("Average step count of storing elements, average(i): " + effort.Average());
            Console.WriteLine();
            Console.WriteLine("Hashing Method Used:");
            Console.WriteLine("First hash method is applied for every character in the current string (h starts with the value of any prime number.): \n\thash1(x)=>h = (h * 31 + currentChar[i])\nSecond hash method is applied for every character in the current string(h starts with the value of zero.): \n\thash2(x)=>h = h + currentChar[i] * NextPrime(i) \nfunctions are used");
            Console.WriteLine();
            Console.WriteLine("Hash table size used: " + rows.Length);
            Console.WriteLine();
        }
    }
}
