class Program
{
    static void Main()
    {
        Liverpool nunez = new Liverpool("Darwin Nunez", "Striker", 14);
        Liverpool gakpo = new Liverpool("Gakpo", "Striker", 10);

        Liverpool alisson = new Liverpool("Alisson Becker", "GoalKeeper", 17);
        Liverpool adrian = new Liverpool("Adrian", "GoalKeeper", 5);

        Liverpool livStriker = nunez + gakpo;
        Liverpool livGoalKeeper = alisson + adrian;

        System.Console.WriteLine($"Liverpool Strikers have score {livStriker.GoalScore} goals this season");
        System.Console.WriteLine($"Liverpool GoalKeepers have conceded {livGoalKeeper.GoalConceded} goals this season");
    }
}