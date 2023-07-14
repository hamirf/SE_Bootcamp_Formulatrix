using System.Collections;

class Vendors<T, T1> : IEnumerable, IEnumerator<T>
{
    private int _position = -1;

    // ArrayList vendorList = new ArrayList();
    List<Vendor<T, T1>> vendorList = new List<Vendor<T, T1>>();

    public void AddVendor(Vendor<T, T1> vendor)
    {
        vendorList.Add(vendor);
    }

    public IEnumerator GetEnumerator()
    {
        return this;
    }

    public T Current
    {
        get
        {
            return vendorList[_position].Id;
        }
    }

    public T1 Currents
    {
        get
        {
            return vendorList[_position].Name;
        }
    }

    object IEnumerator.Current
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

    public void Dispose()
    {
        Reset();
    }
}