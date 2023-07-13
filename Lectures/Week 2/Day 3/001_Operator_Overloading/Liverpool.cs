public class Liverpool
{
    public string? PlayerName { get; set; }
    public string? Position { get; set; }
    public int GoalScore { get; set; }
    public int GoalConceded { get; set; }

    public Liverpool()
    {

    }

    public Liverpool(string position, int goal)
    {
        if (position.Equals("Striker"))
        {
            GoalScore = goal;
        }
        else if (position.Equals("GoalKeeper"))
        {
            GoalConceded = goal;
        }
    }

    public Liverpool(string name, string position, int goal)
    {
        PlayerName = name;
        Position = position;
        if (position.Equals("Striker"))
        {
            GoalScore = goal;
        }
        else if (position.Equals("GoalKeeper"))
        {
            GoalConceded = goal;
        }
    }

    // public Liverpool(string name, string position, int goalConceded)
    // {
    //     PlayerName = name;
    //     Position = position;
    //     GoalConceded = goalConceded;
    // }

    public static Liverpool operator +(Liverpool a, Liverpool b)
    {
        if (a.Position.Equals("Striker") && b.Position.Equals("Striker"))
        {
            return new Liverpool("Striker", (a.GoalScore + b.GoalScore));
        }
        else if (a.Position.Equals("GoalKeeper") && b.Position.Equals("GoalKeeper"))
        {
            return new Liverpool("GoalKeeper", (a.GoalConceded + b.GoalConceded));
        }
        return new Liverpool();
    }
}