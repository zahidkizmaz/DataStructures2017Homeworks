/*
Zahid KIZMAZ
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palindrome
    {
        String input;
        Stack<char> st;
        Queue<char> qu;
        
        public Palindrome(String input)
        {
            this.input = input.ToLower(new System.Globalization.CultureInfo("en-US"));
            this.st = new Stack<char>();
            this.qu = new Queue<char>();
            fillLists();
        }

        /*
        Controlling the users inputs each character by using a speacial regular expression. After they fit to the expression
        putting them into Queue and Stack.
        */
        public void fillLists() {
            Regex r = new Regex("[a-zA-Z0-9]+");

            for (int i = 0; i < input.Length; i++)
            {
                if (r.IsMatch(input[i].ToString()))
                {
                    st.Push(input[i]);
                    qu.Enqueue(input[i]);
                }               
            }
        }

        /*
        Getting every character one by one from our collections. Checking if they are equals from the reversed sorted. 
        */
        public bool checkPalindrome() {
            int palindrome = 0;
            int count = st.Count;
            for (int i = 0; i < count; i++)
            {
                if (st.Pop() == qu.Dequeue())
                    palindrome++;
            }
            return palindrome == count;
        }
    }
}
