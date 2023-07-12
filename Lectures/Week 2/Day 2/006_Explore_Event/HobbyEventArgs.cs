namespace Hobby
{
    public class HobbyEventArgs : EventArgs
    {
        public string MemberTier { get; }
        public string Activity { get; set; }

        public HobbyEventArgs(string tier, string activity)
        {
            MemberTier = tier;
            Activity = activity;
        }
    }
}