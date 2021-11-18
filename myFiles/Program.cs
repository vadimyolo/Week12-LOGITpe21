using System;
using System.IO;

namespace BlackSheep
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\opilane\samples\LOGITpe21\myFiles.txt";
            string[] datafromfile = File.ReadAllLines(filepath);

            for (int i = 0; i < datafromfile.Length; i++)
            {
                datafromfile[i] = datafromfile[i].Replace('3', 'e');
                datafromfile[i] = datafromfile[i].Replace('1', 'i');
                datafromfile[i] = datafromfile[i].Replace('0', 'o');
                datafromfile[i] = datafromfile[i].Replace('4', 'a');
                


            }
            foreach (string line in datafromfile)
            {
                Console.WriteLine(line);
            }
            File.WriteAllLines(filepath, datafromfile);

        }
    }
}