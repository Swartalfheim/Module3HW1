using System.Collections;

namespace Module3HW1
{
    public class CustomCollection<T> : IEnumerable<T>
    {
        private readonly int _baseSize = 5;
        private T[] _array;
        private int _index;
        public CustomCollection()
        {
            _array = new T[_baseSize];
            _index = 0;
        }
        public void Add(T item)
        {
            if (_index >= _array.Length)
            {
                IncreaseCapacity();
            }
            _array[_index++] = item;
        }
        public void AddRange(T[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Add(items[i]);
            }
        }
        public void AddRange(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                Add(item);
            }
        }
        public bool Remove(T item)
        {
            int index = Array.IndexOf(_array, item);
            if (index == -1)
            {
                return false;
            }
            RemoveAt(index);
            return true;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index > _array.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = index; i < _array.Length; i++)
            {
                if (i != _array.Length - 1)
                {
                    _array[i] = _array[i + 1];
                }
                else
                {
                    _array[i] = default(T);
                }
            }
            _index--;
        }
        public void Sort(bool reverse = false)
        {
            Array.Sort(_array);
            if (reverse)
            {
                Array.Reverse(_array);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new CustomCollectionEnumerator<T>(_array);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private void IncreaseCapacity()
        {
            T[] tempArray = new T[_array.Length * 2];
            for (int i = 0; i < _array.Length; i++)
            {
                tempArray[i] = _array[i];
            }
            _array = tempArray;
        }
    }
}
