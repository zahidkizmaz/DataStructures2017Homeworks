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
    class Entry
    {
        string[] lines;
        public Entry(string path)
        {
            try
            {
                lines = System.IO.File.ReadAllLines(path);
            }
            catch (Exception)
            {
                Console.WriteLine("Couldnt find the file in given path.");
            } 
        }
        public string[] Lines { get { return lines; } }
    }
}
