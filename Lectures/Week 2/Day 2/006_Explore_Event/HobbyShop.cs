namespace Hobby;

public delegate void HobbyHandler(object sender, HobbyEventArgs e);

public class HobbyShop
{
    public event HobbyHandler Hobby;
}

public class Member
{
    public string MemberName { get; set; }

    public Member(string name)
    {
        MemberName = name;
    }

    public void MemberEnter()
    {
        Console.WriteLine($"{MemberName} has enter Hobby Shop");
    }
    public void MemberExit()
    {
        Console.WriteLine($"{MemberName} has exit Hobby Shop");
    }
}
