namespace _002_Interface_As_Reference;

public class Player
{
    public IPlayerClass playerClass;
    public IWeapon weapon;
    public IArmor armor;
    public IMount mount;
    public IPet pet;

    public string playerName;

    public Player(string playerName, IPlayerClass playerClass, IWeapon weapon, IArmor armor, IMount mount, IPet pet)
    {
        this.playerName = playerName;
        this.playerClass = playerClass;
        this.weapon = weapon;
        this.armor = armor;
        this.mount = mount;
        this.pet = pet;
    }

}
