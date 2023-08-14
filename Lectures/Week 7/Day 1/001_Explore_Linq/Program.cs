class Program
{
    static void Main()
    {
        Household haidar = new Household("Haidar", 23, "Bandung", 168, "Software Engineer");
        Household asuka = new Household("Asuka", 25, "Tokyo", 158, "Waifu");
        Household kubo = new Household("Kubo", 22, "Miyagi", 161, "Baseball Brand Ambassador");

        List<Household> hakai = new List<Household>() { haidar, asuka, kubo };

        //LINQ with Query Syntax
        var hhName = from h in hakai
                     orderby h.MemberName descending
                     where h.MemberName.Length >= 5
                     select h.MemberName;

        foreach (var name in hhName)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine();

        //LINQ with Lambda Expression
        foreach (var name in hakai.OrderBy(h => h.MemberName).Where(h => h.MemberName.Length <= 5).Select(h => h.MemberName))
        {
            Console.WriteLine(name);
        }

        Console.WriteLine();

        //LINQ with Hybrid Expression
        var orderedName = (from h in hakai
                           orderby h.Height ascending
                           select h.MemberName)
                          .Where(h => h.Length >= 4).Skip(1);

        foreach (var name in orderedName)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine();

        foreach (var member in hakai.OrderBy(h => h.Height))
        {
            Console.WriteLine(member.MemberName + ", " + member.Age + ", " + member.Height + " cm, " + member.Job);
        }

        Console.WriteLine();

        var nameStartsWithA = hakai.Where(h => h.MemberName.StartsWith("A")).Select(h => h.MemberName);
        foreach (var name in nameStartsWithA)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine();

        var nameContainsA = hakai.OrderBy(h => h.MemberName).Where(h => h.MemberName.Contains('a')).Select(h => h.MemberName);
        foreach (var name in nameContainsA)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine();

        var nameNotContainsS = hakai.OrderBy(h => h.MemberName).Where(h => !h.MemberName.Contains('s')).Select(h => h.MemberName);
        foreach (var name in nameNotContainsS)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine();

        var nameContainsU = hakai.OrderBy(h => h.MemberName).Where(h => h.MemberName.Contains('u')).Select(h => h.MemberName);
        foreach (var name in nameContainsU)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine();

        Household suzuka = new Household("Suzuka", 25, "Hiroshima", 156, "Babymetal Main Vocalist");
        hakai.Add(suzuka);

        var nameOrder = hakai.OrderByDescending(h => h.MemberName.Length).ThenBy(h => h.MemberName).Select(h => h.MemberName);
        foreach (var name in nameOrder)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine();



    }
}