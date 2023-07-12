public class Member
{
    public string MemberName { get; set; }
    public string MemberTier { get; set; }
    public string ItemBought { get; set; }

    public Member(string name, string memberTier, string itemBought)
    {
        MemberName = name;
        MemberTier = memberTier;
        ItemBought = itemBought;
    }

    public void ItemBoughtCompleted(object sender, HobbyEventArgs e)
    {
        Console.WriteLine($"{MemberName} the {MemberTier} member has bought {ItemBought} at {((HobbyShop)sender).name}");
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
