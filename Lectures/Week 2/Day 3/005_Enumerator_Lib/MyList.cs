using System.Collections;

class MyList : IEnumerable
{
    private string[] data = { "Corsair", "Lian Li", "Thermaltake", "NZXT" };

    public IEnumerator GetEnumerator()
    {
        return new MyEnumerator(data);
    }

    private class MyEnumerator : IEnumerator
    {
        private string[] data;
        private int position = -1;

        public MyEnumerator(string[] data)
        {
            this.data = data;
        }

        public object Current
        {
            get
            {
                return data[position];
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < data.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }

}
