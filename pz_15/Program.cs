using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace pz_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = @"D:\test.txt";
            using (StreamReader reader = new StreamReader(filename))
            {
                string text = reader.ReadToEnd();
                Console.WriteLine("Содержимое файла:");
                Console.WriteLine(text);             
            }
        }
    }
}