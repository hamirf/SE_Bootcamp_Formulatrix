public class HobbyEventArgs : EventArgs
{
    public string ItemBought { get; set; }

    public HobbyEventArgs(string itemBought)
    {
        ItemBought = itemBought;
    }
}