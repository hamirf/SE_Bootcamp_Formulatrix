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

        var householdMember = members.Join(households, m => m.Id, h => h.MemberId, (m, h) => new
        {
            m.Name,
            m.Age,
            m.Gender,
            m.Height,
            m.POB,
            m.MaritalStatus,
            h.InHouse
        }).ToList();

        foreach (var member in householdMember)
        {
            Console.WriteLine($"{member.Name}, {member.Gender}, {member.POB}, {member.Age}, {member.Height}, {member.InHouse}");
        }

    }
}