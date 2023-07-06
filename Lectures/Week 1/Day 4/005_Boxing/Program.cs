
namespace Object
{
    static class Program
    {
        static void Main()
        {
            int x = 2;
            object obj1 = x; // boxing
            int y = (int)obj1; // unboxing
            Console.WriteLine(y);

            int a = 10;
            object obj2 = a;
            //string str1 = (string)obj2;
            string str = ((int)obj2).ToString(); // unboxing convert
            Console.WriteLine(str);

            int c = 11;
            object obj3 = c;
            //long d = (long)(int)obj3; 
            long d = (int)obj3; // unboxing upcast
            Console.WriteLine(d);

            float e = 12.2f;
            object obj6 = e;
            //int i = (int)obj6; 
            int i = (int)(float)obj6; // unboxing downcast
            Console.WriteLine(i);

            object obj4 = "Hello, Asuka";
            // Unboxing manual
            if (obj4 is string)
            {
                string str4 = (string)obj4;
                Console.WriteLine(str4);
            }

            object obj5 = "Hello, World! 2";
            // Unboxing otomatis langsung tertampung
            if (obj5 is string str5) //pattern matching
            {
                Console.WriteLine(str5);
            }

            object obj7 = 22;
            // Bentuk penulisan lain dari pengkondisian If
            int j = obj7 as int? ?? 0;
            Console.WriteLine(j);
        }
    }
}