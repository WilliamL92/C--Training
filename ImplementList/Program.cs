using System.Collections;
using System.Collections.Generic;

public class MyList<T>
{
    private T[] _list = [];
    private int _index = 0;
    public MyList()
    {
        
    }

    public void Add(T elem)
    {
        Array.Resize(ref _list, _list.Length + 1);
        _list[_index] = elem;
        _index++;
    }

    public void Remove(T elem) 
    {
        T[] tempArr = new T[_list.Length];
        Array.Copy(_list, tempArr, _list.Length);
        int cursor = -1;
        bool elemFind = false;
        for (int i = 0; i < tempArr.Length; i++) 
        {
            if (tempArr[i].Equals(elem) && !elemFind)
            {
                cursor = i;
                elemFind = true;
            }
            else if (cursor != -1) {
                _list[i - 1] = tempArr[i];
            }
        }
        if (elemFind)
        {
            Array.Resize(ref _list, _list.Length - 1);
            _index--;
        }
    }

    public int Count
    {
        get { return _list.Length; }
       
    }
    public T GetItems(int index)
    {
        return _list[index];
    }
}

public class Program
{
    static void Main(string[] args)
    { 
    }
}