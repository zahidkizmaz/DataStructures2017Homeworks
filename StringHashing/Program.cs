/*
Zahid KIZMAZ 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3VY14253043
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"sozluk2.txt";
            Entry e = new Entry(path);
            HashTable tbl = new HashTable(e.Lines);
            tbl.Hash();
            tbl.displayStatistics();
        }
    }
}
