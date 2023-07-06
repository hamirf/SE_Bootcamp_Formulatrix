using _002_Interface_As_Reference;

class Program
{
    static void Main()
    {
        Warrior warrior = new("Warrior");
        Greatsword greatsword = new();
        Plate plate = new();
        Chimera chimera = new();
        Mule mule = new();

        Player haiqi = new("Haiqi", warrior, greatsword, plate, mule, chimera);
        string haiqiAttack = warrior.PlayerAttack();
        string haiqiSkill = warrior.PlayerSkill();
        Console.WriteLine($"Player {haiqi.playerName} that is {warrior.className}, consecutively {haiqiAttack} and uses {haiqiSkill}");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine(greatsword.WeaponVulnerability());
    }
}