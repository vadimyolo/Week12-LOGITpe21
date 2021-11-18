using System;
using System.IO;

namespace Quotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("49 Wise Quotes That Will Inspire You to Success in Life");
            string rootpath = @"C:\Users\opilane\samples\LOGITpe21\quotes.txt";
            string[] datafromfile = File.ReadAllLines(rootpath);

            Random rnd = new Random();
            int randomindex = rnd.Next(1, datafromfile.Length);

            Console.WriteLine(datafromfile[randomindex]);
        }

    }
}