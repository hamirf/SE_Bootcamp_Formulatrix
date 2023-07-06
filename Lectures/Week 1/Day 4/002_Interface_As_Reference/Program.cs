using _002_Interface_As_Reference;

class Program
{
    static void Main()
    {
        Warrior warrior = new Warrior();
        Greatsword greatsword = new Greatsword();
        Plate plate = new Plate();
        Chimera chimera = new Chimera();
        Mule mule = new Mule();

        Player haiqi = new Player(warrior, greatsword, plate, mule, chimera);
        haiqi.PlayerAttack();
    }
}