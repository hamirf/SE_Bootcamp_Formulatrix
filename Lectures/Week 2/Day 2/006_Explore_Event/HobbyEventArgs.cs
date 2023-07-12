public class HobbyEventArgs : EventArgs
{
    // public string ItemBought { get; set; }
    public Member Member { get; set; }

    public HobbyEventArgs(Member member)
    {
        Member = member;
    }
}