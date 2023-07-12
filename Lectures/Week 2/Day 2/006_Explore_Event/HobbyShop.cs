public delegate void HobbyHandler(object sender, HobbyEventArgs e);

public class HobbyShop
{
    public event HobbyHandler HobbyCompleted;
    public string name;

    public HobbyShop(string name)
    {
        this.name = name;
    }

    public void BuyItem(string itemBought)
    {
        Console.WriteLine($"Buying {itemBought}");
        HobbyEventArgs hobbyEventArgs = new HobbyEventArgs(itemBought);
        BuyItemCompleted(hobbyEventArgs);
    }

    public virtual void BuyItemCompleted(HobbyEventArgs e)
    {
        HobbyCompleted?.Invoke(this, e);
    }
}

public class Member
{
    public string MemberName { get; set; }
    public string MemberTier { get; set; }

    public Member(string name, string memberTier)
    {
        MemberName = name;
        MemberTier = memberTier;
    }

    public void ItemBoughtCompleted(object sender, HobbyEventArgs e)
    {
        Console.WriteLine($"{MemberName} the {MemberTier} member has bought {e.ItemBought} at {((HobbyShop)sender).name}");
    }

    public void MemberEnter(HobbyShop hobbyShop)
    {
        Console.WriteLine($"{MemberName} has enter Hobby Shop");
        hobbyShop.HobbyCompleted += ItemBoughtCompleted;
    }
    public void MemberExit(HobbyShop hobbyShop)
    {
        Console.WriteLine($"{MemberName} has exit Hobby Shop");
        hobbyShop.HobbyCompleted -= ItemBoughtCompleted;
    }
}
