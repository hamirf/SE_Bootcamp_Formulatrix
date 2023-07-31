namespace CharacterDetail;

public class Character
{
    private string _name;
    private int _id;
    private int _health;
    private int _attack;
    private double _aspd;

    public Character()
    {
    }

    public Character(string name, int id, int health, int attack, double aspd)
    {
        _name = name;
        _id = id;
        _health = health;
        _attack = attack;
        _aspd = aspd;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public int GetId()
    {
        return _id;
    }

    public void SetId(int id)
    {
        Random random = new Random();
        _id = random.Next(id);
    }

    public int GetHealth()
    {
        return _health;
    }

    public void SetHealth(int health)
    {
        _health = health;
    }

    public int GetAttack()
    {
        return _attack;
    }

    public void SetAttack(int attack)
    {
        _attack = attack;
    }

    public double GetAspd()
    {
        return _aspd;
    }

    public void SetAspd(double aspd)
    {
        _aspd = aspd;
    }

    public string DecreaseHealth(Character character)
    {
        _health = (int)(_health - (character.GetAspd() * character.GetAttack()));
        return $"{_name} receive attack from {character.GetName()}! Your health now is {_health}";
    }

    public string Attack(Character character)
    {
        return $"{_name} deal {_attack} damage to {character.GetName()}!";
    }
}