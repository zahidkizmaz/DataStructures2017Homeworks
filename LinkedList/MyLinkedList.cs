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
    class MyLinkedList <T> where T : IComparable
    {
        Node<T> root;
        int count;

        public MyLinkedList(T value)
        {
            Node<T> root = new Node<T>(value);
            this.root = root;
        }

        public void addOrdered(T value) {
            Node<T> nn = new Node<T>(value);
            Node<T> iter = root;
            if (root == null)
            {
                root = nn;
                return;
            }
            if (value.CompareTo(root.value) != 1)
            {
                nn.next = root;
                root = nn;
                return;
            }
            while (iter.next != null && iter.next.value.CompareTo(value) != 1)
                iter = iter.next;

            if (iter.next == null)
            {
                iter.next = nn;
                nn.next = null;
                return;
            }
            nn.next = iter.next;
            iter.next = nn;
        }

        public void remove(T val) {
            if (search(val) == null)
            {
                Console.WriteLine("Couldnt remove element:" + val + " List has no such element.");
                return;
            }
            if (val.CompareTo(root.value) == 0)
            {
                root = root.next;
                return;
            }
            Node<T> iter = root;
            while (iter.next.value.CompareTo(val) != 0 )
                iter = iter.next;

            if (iter.next.next == null)
            {
                iter.next = null;
                return;
            }
            else
            {
                iter.next = iter.next.next;
            }           
        }

        public void clear() {
            root = null;
        }

        public void print() {
            Node<T> tmp = Root;
            while (tmp != null)
            {
                Console.Write(tmp.value + "->");
                tmp = tmp.next;
            }
            Console.Write("NULL\n\n");             
        }
        internal Node<T> Root
        {
            get
            {
                return root;
            }
        }

        public Node<T> search(T val) {
            Node<T> iter = root;
            while (iter != null)
            {
                if (iter.value.CompareTo(val) == 0)
                {
                    return iter;
                }
                iter = iter.next;
            }
            return null;
        }

        public int Count
        {
            get
            {
                Node<T> tmp = root;
                count = 0;
                while (tmp != null) { 
                    tmp = tmp.next;
                    count++;
                }
                return count;
            }
        }
    }
}
