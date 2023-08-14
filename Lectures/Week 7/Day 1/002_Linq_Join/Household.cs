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
