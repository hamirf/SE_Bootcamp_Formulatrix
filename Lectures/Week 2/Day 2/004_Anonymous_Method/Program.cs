using System;

namespace Delegates
{
    class Program
    {
        // Delegate Definition
        delegate void operation();

        static void Main(string[] args)
        {
            // Delegate instantiation
            operation obj = delegate
            {
                Console.WriteLine("Anonymous method");
            };
            obj();

            Console.ReadLine();
        }
    }
}