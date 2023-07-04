using Static;

class Program 
{
	static void Main() 
	{
        //calcSizeNotStatic = 2, calcSize = 2
		Calculator calculator = new Calculator(2);

        //calcSizeNotStatic = 1, calcSize = 1
		Calculator calculator1= new Calculator(1);

        //Non-static class without instance, static method; calcSize = 1
		Console.WriteLine(Calculator.ReturnSizeCalc());
        //Non-static class with instance, non-static method; calcSize = 1
		Console.WriteLine(calculator.ReturnSize());
        //Non-static class with instance, non-static method; calcSize = 1
		Console.WriteLine(calculator1.ReturnSize());
        //Non-static class with instance, static method; output error. Karena instance/objek tidak bisa mengubah static method
        // Console.WriteLine(calculator.ReturnSizeCalc());
        //Instance want to change the value of static variable (calcSize), error Karena instance/objek tidak bisa mengubah static variable
        // calculator1.calcSize = 2;
	}
}