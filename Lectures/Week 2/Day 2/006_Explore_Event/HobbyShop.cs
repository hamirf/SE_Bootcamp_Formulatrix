// public delegate void HobbyHandler(object sender, HobbyEventArgs e);

public class HobbyShop
{
    public event EventHandler<HobbyEventArgs> HobbyCompleted;
    public string name;

    public HobbyShop(string name)
    {
        this.name = name;
    }

    public void BuyItem(Member member)
    {
        Console.WriteLine($"{member.MemberName} buying {member.ItemBought}");
        HobbyEventArgs hobbyEventArgs = new HobbyEventArgs(member);
        BuyItemCompleted(hobbyEventArgs);
    }

    public virtual void BuyItemCompleted(HobbyEventArgs e)
    {
        HobbyCompleted?.Invoke(this, e);
    }
}