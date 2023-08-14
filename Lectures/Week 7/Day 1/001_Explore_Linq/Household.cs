public class Household
{
    public string MemberName { get; set; }
    public int Age { get; set; }
    public string POB { get; set; }
    public int Height { get; set; }
    public string Job { get; set; }

    public Household(string memberName, int age, string pob, int height, string job)
    {
        MemberName = memberName;
        Age = age;
        POB = pob;
        Height = height;
        Job = job;
    }
}
