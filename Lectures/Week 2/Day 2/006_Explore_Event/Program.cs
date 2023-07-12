class Program
{
    static void Main()
    {
        HobbyShop saiyanShop = new HobbyShop("Saiyan Hobby Shop");
        Member haidar = new Member("Haidar", "Platinum", "2 Goku Action Figures");

        haidar.MemberEnter(saiyanShop);
        saiyanShop.BuyItem(haidar);
        haidar.MemberExit(saiyanShop);
        Console.WriteLine();

        Member unknown = new Member(null, "None", "Skateboard");

        saiyanShop.BuyItem(unknown);
    }
}