using System;

class Program
{
    static void Main()
    {
        MyList list = new MyList();

        foreach (var itemList in list)
        {
            System.Console.WriteLine(itemList);
        }
    }
}