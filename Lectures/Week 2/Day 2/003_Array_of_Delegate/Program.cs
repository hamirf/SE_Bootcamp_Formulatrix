using System;

namespace Delegates
{
    public class Operation
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition = {0}", a + b);
        }

        public static void Multiple(int c, int d)
        {
            Console.WriteLine("Multiply = {0}", c * d);
        }

        public static void Substract(int e, int f)
        {
            Console.WriteLine("Substract = {0}", e - f);
        }

        public static void Divide(int g, int h)
        {
            Console.WriteLine("Divide = {0}", g / h);
        }
    }

    class Program
    {
        delegate void DelOp(int x, int y);

        static void Main(string[] args)
        {
            // Delegate instantiation
            DelOp[] obj =
           {
               new DelOp(Operation.Add),
               new DelOp(Operation.Substract),
               new DelOp(Operation.Multiple),
               new DelOp(Operation.Divide)
           };

            for (int i = 0; i < obj.Length; i++)
            {
                obj[i](2, 5);
                obj[i](8, 5);
                obj[i](4, 6);
            }
            Console.ReadLine();
        }
    }
}