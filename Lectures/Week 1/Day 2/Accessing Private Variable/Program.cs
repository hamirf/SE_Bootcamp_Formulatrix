using EmployeeLibrary;
class Program
{
    static void Main()
    {
        Employee yusuf = new Employee("yusuf", 1000);
        //string name = employee._name;
        string? namaEmployee = yusuf.GetName("password");

        bool nameEmployee = yusuf.SetName("januar");
        if (nameEmployee)
        {
            Console.WriteLine("nama sesuai");
        }
        else
        {
            Console.WriteLine("name tidak sesuai");
        }

        yusuf.SetAge("5");
        // yusuf.Age = "5";
        Console.WriteLine(yusuf.Age);

        yusuf.Age2 = "2";
        Console.WriteLine(yusuf.Age2);

        decimal salary = yusuf.GetSalary();
        Console.WriteLine("Employee salary : " + salary);
    }
}