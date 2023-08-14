class Program
{
    static void Main(string[] args)
    {
        Household member1 = new Household(1, true);
        Household member2 = new Household(2, true);
        Household member3 = new Household(3, false);
        Household member4 = new Household(4, false);

        Member haidar = new Member(1, "Haidar Amir Faruqi", 'L', "Bandung", 23, 168, false);
        Member asuka = new Member(2, "Asuka Saito", 'P', "Tokyo", 25, 158, false);
        Member kubo = new Member(3, "Kubo Shiori", 'P', "Miyagi", 22, 161, false);
        Member sumetal = new Member(4, "Suzuka Nakamoto", 'P', "Hiroshima", 25, 156, false);

        List<Household> households = new List<Household>() { member1, member2, member3, member4 };
        List<Member> members = new List<Member>() { haidar, asuka, kubo, sumetal };

        var joinMember = members.Join(households, m => m.Id, h => h.MemberId, (m, o) => new {});
    }
}

public class Household
{
    public Household()
    {
    }

    public Household(int memberId, bool inHouse)
    {
        MemberId = memberId;
        InHouse = inHouse;
    }
    public int MemberId { get; set; }
    public bool InHouse { get; set; }
}

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