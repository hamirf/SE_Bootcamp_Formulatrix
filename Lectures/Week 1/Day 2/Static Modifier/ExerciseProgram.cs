using Luas_Rumah;

namespace Static_Modifier;

public class ExerciseProgram
{
    static void Main()
    {
        House.luasTanah = 60;
        House tipeA = new House("A", 6, 8);
        House tipeB = new House("B", 7, 10);

        // Instance tidak bisa mengakses static method maupun variable 
        // tipeA.luasKavling();
        Console.WriteLine(House.luasKavling());

        Console.WriteLine(tipeA.luasBangunanType());
        Console.WriteLine(tipeB.luasBangunanType());

    }
}
