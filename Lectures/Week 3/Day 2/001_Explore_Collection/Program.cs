using System.Collections.Generic;
public class Program
{
    static void Main()
    {
        Dota2 dota = new Dota2();
        dota.AddByRating(1, "Gaimin Gladiators");
        dota.AddByRating(2, "Team Liquid");
        dota.AddByRating(3, "Tundra Esports");
        dota.AddByRating(4, "Evil Geniuses");
        dota.AddByRating(5, "9Pandas");

        dota.AddByDPCPoint(1, "Gaimin Gladiators");
        dota.AddByDPCPoint(2, "Team Liquid");
        dota.AddByDPCPoint(3, "Tundra Esports");
        dota.AddByDPCPoint(4, "9Pandas");
        dota.AddByDPCPoint(5, "Evil Geniuses");

        dota.AddByEarned(1, "Gaimin Gladiators");
        dota.AddByEarned(2, "Team Liquid");
        dota.AddByEarned(3, "Tundra Esports");
        dota.AddByEarned(4, "Talon Esports");
        dota.AddByEarned(5, "Shopify Rebellion");

        dota.overallRankings();
    }
}