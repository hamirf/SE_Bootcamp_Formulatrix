class Program
{
    static void Main()
    {
        // DaysOfWeek hari = DaysOfWeek.Monday;
        // Console.WriteLine(hari);  
        foreach (var day in Enum.GetValues(typeof(DaysOfWeek)))
        {
            // Console.WriteLine(day.ToString());
            // Console.WriteLine(day);
            Console.WriteLine((int)day);
        }      

        string newDay = "Payday";
        DaysOfWeek theDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), newDay);
        Console.WriteLine($"The parsed string of day is : {theDay}");
    }    
}

public enum DaysOfWeek {
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday,
    Payday,
}