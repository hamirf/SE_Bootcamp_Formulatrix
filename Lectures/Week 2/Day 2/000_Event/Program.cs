using System;

namespace Delegates
{
    public delegate void DelEventHandler();

    class Program
    {
        public static event DelEventHandler Add;

        static void Main(string[] args)
        {
            Add += new DelEventHandler(USA);
            Add += new DelEventHandler(India);
            Add += new DelEventHandler(England);
            Add.Invoke();
        }
        static void USA()
        {
            Console.WriteLine("USA");
        }

        static void India()
        {
            Console.WriteLine("India");
        }

        static void England()
        {
            Console.WriteLine("England");
        }
    }
}