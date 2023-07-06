
namespace Object
{
    static class Program
    {
        static void Main()
        {
            // Tipe data dynamic bisa berubah - ubah dari satu tipe data ke tipe data lain
            int x = 2;
            dynamic obj1 = x;
            Console.WriteLine(obj1);

            int a = 10;
            dynamic obj2 = a;
            //string str = obj2;
            string str = obj2.ToString();
            Console.WriteLine(str);

            int c = 11;
            dynamic obj3 = c;
            long d = obj3;
            Console.WriteLine(d);

            dynamic obj4 = "Hello, Asuka";
            if (obj4 is string x2)
            {
                Console.WriteLine(x2);
            }

            dynamic obj5 = "Hello, Saito Asuka";
            string str5 = obj5;
            if (str5 != null)
            {
                Console.WriteLine(str5);
            }

            dynamic myVar = 100; //dangerous
            myVar = "Hello World";
            myVar = true;
            Console.WriteLine(myVar);

        }
    }
}