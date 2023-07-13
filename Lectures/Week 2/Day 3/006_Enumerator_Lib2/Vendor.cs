class Vendor
{
    private int _id;
    private string _name;

    public Vendor(int id, string name)
    {
        this._id = id;
        this._name = name;
    }

    public int Id { get => _id; }
    public string Name { get => _name; }

    public override string? ToString()
    {
        return $"{Name} has id number {Id}";
    }
}
