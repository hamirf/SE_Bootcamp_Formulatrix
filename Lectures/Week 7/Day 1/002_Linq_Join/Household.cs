public class Household
{
    public Household()
    {
    }

    public Household(int memberId, string job, bool inHouse)
    {
        MemberId = memberId;
        Job = job;
        InHouse = inHouse;
    }
    public int MemberId { get; set; }
    public string Job { get; set; }
    public bool InHouse { get; set; }
}
