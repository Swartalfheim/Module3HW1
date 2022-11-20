namespace M3HW1
{
    public class GenericList<T>
    {
        private List<T> _list = new List<T>();

        public List<T> Added(T a)
        {
            _list.Add(a);
            return _list;
        }

        public List<T> AddedArray(T[] a)
        {
            _list.AddRange(a);
            return _list;
        }

        public List<T> Sorted()
        {
            _list.Sort();
            return _list;
        }

        public List<T> Removal(T a)
        {
            _list.Remove(a);
            return _list;
        }

        public List<T> RemovalAt(int a)
        {
            _list.RemoveAt(a);
            return _list;
        }

        public void PrintInfo()
        {
            foreach (T a in _list)
            {
                Console.Write($"{a}; ");
            }

            Console.WriteLine();
        }
    }
}
