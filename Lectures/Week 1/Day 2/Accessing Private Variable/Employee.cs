namespace EmployeeLibrary;

public class Employee
{
    private string _name;
    private string? _emailAddress;
    private decimal _salary;
    private string _email;

    public string? Age { get; private set; }
    // public string Age;
    // private string _age;


    public string? Age2;

    public Employee(string name, decimal salary)
    {
        _name = name;
        if (salary > 0)
        {
            _salary = salary;
        }
        else
        {
            _salary = 3000;
        }
        _email = "defaultMail@gmail.com";
    }

    public void SetAge(string age)
    {
        Age = age;
    }
    // public string GetAge() 
    // {
    //     return _age;
    // }
    // public void SetAge(string age) {
    //     _age =  age;
    // } 

    public string? GetName(string password)
    {
        if (password == "password")
        {
            return _name;
        }
        return null;
    }
    public bool SetName(string name)
    {
        if (name != null)
        {
            _name = name;
            return true;
        }
        return false;
    }

    public decimal GetSalary()
    {
        return _salary;
    }

    public string GetEmail()
    {
        return _email;
    }
}
