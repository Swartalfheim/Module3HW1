using System.Collections;

namespace Module3HW1
{
    public class CustomCollectionEnumerator<T> : IEnumerator<T>
    {
        private T[] _array;
        private int _position;
        public CustomCollectionEnumerator(T[] array)
        {
            _position = -1;
            _array = array;
        }
        public T Current
        {
            get
            {
                if (_position < 0 || _position >= _array.Length)
                {
                    throw new InvalidOperationException();
                }
                return _array[_position];
            }
        }
        object IEnumerator.Current => throw new NotImplementedException();
        public void Dispose()
        {
             // throw new NotImplementedException();
        }
        public bool MoveNext()
        {
            if (_position < _array.Length - 1)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            _position = -1;
        }
    }
}
