using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Computer test = new Computer(2, 3, "Apple");
            Console.WriteLine(test.Id);
           
        }
    }
}