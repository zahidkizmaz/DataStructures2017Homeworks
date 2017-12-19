/*
Zahid KIZMAZ
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    class Node <T> where T : IComparable
    {
        public T value;
        public Node<T> next;
        public Node(T value)
        {
            this.value = value;
        }
        public bool isNull()
        {
            return this.value == null;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}
