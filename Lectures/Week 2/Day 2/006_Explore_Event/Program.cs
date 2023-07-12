class Program
{
    static void Main()
    {
        HobbyShop saiyanShop = new HobbyShop("Saiyan Hobby Shop");
        Member haidar = new Member("Haidar", "Platinum");

        haidar.MemberEnter(saiyanShop);
        saiyanShop.BuyItem("2 Goku Action Figures");
        haidar.MemberExit(saiyanShop);
        Console.WriteLine();

        saiyanShop.BuyItem("Skateboard");
    }
}