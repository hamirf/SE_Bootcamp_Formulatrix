class Vendor<T, T1>
{
    private T _id;
    private T1 _name;

    public Vendor(T id, T1 name)
    {
        this._id = id;
        this._name = name;
    }

    public T Id { get => _id; }
    public T1 Name { get => _name; }

    // public override string? ToString()
    // {
    //     return $"{Name} has id number {Id}";
    // }
}
