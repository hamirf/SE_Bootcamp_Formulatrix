public class Member
{
    public Member()
    {
    }

    public Member(int id, string name, char gender, string pOB, int age, int height, bool maritalStatus)
    {
        Id = id;
        Name = name;
        Gender = gender;
        POB = pOB;
        Age = age;
        Height = height;
        MaritalStatus = maritalStatus;

    }
    public int Id { get; set; }
    public string Name { get; set; }
    public char Gender { get; set; }
    public string POB { get; set; }
    public int Age { get; set; }
    public int Height { get; set; }
    public bool MaritalStatus { get; set; }

}