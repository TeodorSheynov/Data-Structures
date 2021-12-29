using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Data_Structures
{
    public class Array<T>
    {
        private const int _initialSize = 8;

        private T[] _arr;
        private static int _size;
        private int _index=0;
        private static int _count = 0;


        public Array()
        {
            this._arr = new T[_initialSize];
            _size = _initialSize;
        }

        public int Count => _count;

        public void Add(params T[] args)
        {
            foreach (var item in args)
            {
                Add(item);
            }
        }
        public void Add(T item)
        {
            if (_count==_size)
            {
                _size *= 2;
                _arr = Resize(_arr);
            }

            _arr[_index] = item;
            _index++;
            _count++;
            
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public string Show()
        {
            if (_count == 0)
            {
                return "Empty Array.";
            }

            StringBuilder sb = new StringBuilder();

            sb.Append("[");
            for (int i = 0; i < _count; i++)
            {
                string element= i!=_count-1 ? $"{_arr[i]}, " : $"{_arr[i]}";
                sb.Append(element);
            }

            sb.Append("]");
            return sb.ToString().TrimEnd();
        }

        public void Clear()
        {
            _arr = new T[_initialSize];
            _size = _initialSize;
            _count = 0;
            _index = 0;
        }

        public void RemoveAt(int index)
        {
            if (_count == 0 || index < 0 || index > _index)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = index; i < _count-1; i++)
            {
                _arr[i] = _arr[i + 1];
            }
            _count--;
            _index--;

            if (_size/2==_count)
            {
                _size /= 2;
                _arr = Resize(_arr);
            }
        }
        public static T[] Resize(T[] arr)
        {
            T[] resizedArr = new T[_size];
            for (int i = 0; i < _count; i++)
            {
                resizedArr[i] = arr[i];
            }
            arr = resizedArr;
            return arr;
        }
    }
}
