using System.Collections;

class Vendors : IEnumerable, IEnumerator
{
    private int _position = -1;

    // ArrayList vendorList = new ArrayList();
    List<Vendor> vendorList = new List<Vendor>();

    public void AddVendor(Vendor vendor)
    {
        vendorList.Add(vendor);
    }

    public IEnumerator GetEnumerator()
    {
        return this;
    }

    public object Current
    {
        get
        {
            return vendorList[_position];
        }
    }

    public bool MoveNext()
    {
        _position++;
        return (_position < vendorList.Count);
    }

    public void Reset()
    {
        _position = -1;
    }
}