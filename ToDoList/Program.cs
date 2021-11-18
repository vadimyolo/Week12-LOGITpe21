using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> TodoFromfile = new List<string>();
            string TodoFilepath = @"C:\Users\opilane\samples\LOGITpe21\ToDoList.txt";
            TodoFromfile = File.ReadAllLines(TodoFilepath).ToList();

            foreach (string task in TodoFromfile)
            {
                Console.WriteLine(task);
            }

            bool loopactive = true;

            while (loopactive)
            {
                Console.WriteLine("Would you like to add a task? Y/N");
                char userinput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userinput == 'y')
                {
                    Console.WriteLine("enter a task");
                    string usertask = Console.ReadLine();
                    TodoFromfile.Add(usertask);
                    Console.WriteLine($"task {usertask} added.");

                }
                else
                {
                    Console.WriteLine("take care!");
                    loopactive = false;
                }

            }
            File.WriteAllLines(TodoFilepath, TodoFromfile.ToArray());
        }
    }
}
