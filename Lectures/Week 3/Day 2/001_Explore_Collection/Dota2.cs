public class Dota2
{
    public int Points { get; set; }
    public string? Team { get; set; }

    List<KeyValuePair<int, string>> rankings = new();
    List<KeyValuePair<string, int>> overall = new();

    public void AddByRating(int rank, string team)
    {
        rankings.Add(new(rank, team));
    }
    public void AddByDPCPoint(int rank, string team)
    {
        rankings.Add(new(rank, team));
    }
    public void AddByEarned(int rank, string team)
    {
        rankings.Add(new(rank, team));
    }
    public void overallRankings()
    {
        rankings = rankings.OrderBy(kvp => kvp.Value).ToList();
        for (int i = 0; i < rankings.Count - 1; i++)
        {
            // System.Console.WriteLine(rankings[i].Value);
            if (rankings[i].Key == 1)
            {
                Points += 1000;
            }
            else if (rankings[i].Key == 2)
            {
                Points += 750;
            }
            else if (rankings[i].Key == 3)
            {
                Points += 500;
            }
            else if (rankings[i].Key == 4)
            {
                Points += 250;
            }

            if (!rankings[i].Value.Equals(rankings[i + 1].Value))
            {
                Team = rankings[i].Value;
                overall.Add(new(Team, Points));
                Points = 0;
            }
        }

        sortOverall(overall);
    }

    public void sortOverall(List<KeyValuePair<string, int>> overall)
    {
        System.Console.WriteLine("Dota 2 Overall Ranking Season 12: ");
        int i = 0;
        int temp = 0;
        int pointBefore = 0;

        // 1, ranking (i) = 1 + 0 = 1; temp = 0; i = 2;
        // 1 & 2 poin beda, maka ranking (i) = 2 + 0 = 2; temp = 0; i = 3;
        // 2 & 3 poin beda, maka ranking (i) = 3 + 0 = 3; temp = 0; i = 4;
        // 3 & 4 poin sama, maka ranking (i) = 4 - 1 = 3; temp = 1; i = 4;
        // 4 & 5 poin sama, maka ranking (i) = 4 - 1 = 3; temp = 2; i = 4;
        // 5 & 6 poin beda, maka ranking (i) = 4 + 2 = 6; temp = 0; i = 7;
        foreach (var teamRanking in overall.OrderByDescending(kvp => kvp.Value))
        {
            i++;
            int pointNow = teamRanking.Value;
            if (pointBefore == pointNow)
            {
                i--;
                temp++;
            }
            else
            {
                i += temp;
                temp = 0;
            }
            System.Console.WriteLine($"{i}. {teamRanking.Key} with {teamRanking.Value} point(s)");
            pointBefore = pointNow;
        };
    }
}