﻿namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Program program = new Program();
            program.Start();
        }
        void Start()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = int .Parse(Console.ReadLine());
            Console.WriteLine();

            Person person = new Person(age, name);


            person.Display();
        }
    }
}
