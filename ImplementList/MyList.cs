namespace ImplementList
{
    public class MyList<T>
    {
        private T[] _list;
        private int _defaultCapacity = 4;
        private int _count = 0;

        public MyList()
        {
            _list = new T[_defaultCapacity];
        }

        public int Capacity
        {
            get { return _list.Length; }
            set
            {
                if (value != _list.Length)
                {
                    if (value > 0)
                    {
                        T[] tempArray = new T[value];
                        if (_count > 0)
                        {
                            Array.Copy(_list, tempArray, _count);
                        }
                        _list = tempArray;
                    }
                    else
                    {
                        _list = new T[_defaultCapacity];
                    }
                }
            }
        }

        public int Count
        {
            get { return _count; }
        }

        public void Add(T elem)
        {
            if (_count >= Capacity)
            {
                Capacity = Capacity == 0 ? _defaultCapacity : Capacity * 2;
            }
            _list[_count] = elem;
            _count++;
        }

        public bool Remove(T elem)
        {
            int index = -1;
            for (int i = 0; i < _count; i++)
            {
                if (_list[i].Equals(elem))
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
                return false;

            int shiftCount = _count - index - 1;

            if (shiftCount > 0)
            {
                Array.Copy(_list, index + 1, _list, index, shiftCount);
            }
            _list[--_count] = default(T);
            return true;
        }

        public T GetItem(int index)
        {
            if (index >= 0 && index < _count)
            {
                return _list[index];
            }
            throw new ArgumentOutOfRangeException($"Index should be between 0 and {_count - 1}, received: {index}");
        }
    }
}
