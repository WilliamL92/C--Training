namespace ImplementList
{
    public class MyList<T>
    {
        private T[] _list = [];
        private int _defaultCapacity = 4;
        private int _size = 0;
        public MyList()
        {

        }

        public int Capacity {  
            get { return _size; }
            set
            {
                if (value > _list.Length)
                {
                    T[] tempArray = new T[value];
                    Array.Copy(_list, tempArray, value);
                    _list = tempArray;
                }
                _size = value;
            }
        }

        public void Add(T elem)
        {
            if(_size == 0)
            {
                Capacity = _defaultCapacity;
            }
            else
            {
                _size++;
                if(_size > Capacity)
                {
                    Capacity *= 2;
                }
            }
            _list[_size] = elem;
            _size++;
        }

        public void Remove(T elem)
        {
            int cursor = -1;
            bool elemFind = false;
            for (int i = 0; i < _list.Length; i++)
            {
                if (_list[i].Equals(elem) && !elemFind)
                {
                    cursor = i;
                    elemFind = true;
                }
                else if (cursor != -1)
                {
                    _list[i - 1] = _list[i];
                }
            }
            if (elemFind)
            {
                Capacity--;
                _size--;
            }
        }

        public int Count
        {
            get { return _list.Length; }

        }
        public T GetItems(int index)
        {
            if (index >= 0)
            {
                return _list[index];
            }
            throw new ArgumentException($"Index should be >= 0, received: {index}");
        }
    }
}
