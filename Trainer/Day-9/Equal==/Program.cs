using System;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 10;

            bool isEqualOperatorInt = num1 == num2;
            Console.WriteLine("Using == operator with integers: " + isEqualOperatorInt);  // Output: True

            bool isEqualMethodInt = num1.Equals(num2);
            Console.WriteLine("Using Equals() method with integers: " + isEqualMethodInt);  // Output: True
            System.Console.WriteLine("==========1==========");

            string str1 = "Hello";
            string str2 = "Hello";

            bool isEqualOperatorString = str1 == str2;
            Console.WriteLine("Using == operator with strings: " + isEqualOperatorString);  // Output: True

            bool isEqualMethodString = str1.Equals(str2);
            Console.WriteLine("Using Equals() method with strings: " + isEqualMethodString);  // Output: True
            System.Console.WriteLine("==========2==========");

            string str = "hello";
            str2 = "hello";
            Console.WriteLine("Using Equality operator: {0}", str == str2);
            Console.WriteLine("Using equals() method: {0}", str.Equals(str2));
            System.Console.WriteLine("==========3==========");

            object str3 = "hello";
            char[] values = { 'h', 'e', 'l', 'l', 'o' };
            string hello = "hell";
            hello += "o";
            // object str4 = new string(values);
            object str4 = new string(hello);
            // Operator membanding value dari referencenya, bukan value variabel 
            Console.WriteLine("Using Equality operator: {0}", str3 == str4); // False
            Console.WriteLine("Using equals() method: {0}", str3.Equals(str4)); // True
            System.Console.WriteLine("==========4==========");

            var a = new MyClass(1);
            var b = new MyClass(1);
            var c = a;
            Console.WriteLine(a == b);
            Console.WriteLine(a == c);
            Console.WriteLine("Using Equality operator a & b: {0}", a == b);
            Console.WriteLine("Using equals() method a & b: {0}", a.Equals(b));
            System.Console.WriteLine("==========5==========");
        }
    }

    public class MyClass
    {
        private int id;

        public MyClass(int id) => this.id = id;
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            MyClass other = (MyClass)obj;
            return id == other.id;
        }

    }
}
