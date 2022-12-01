namespace Module3HW1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomCollection<int> c = new CustomCollection<int>();
            int[] testMass = new int[] { 8, 8, 8 };
            List<int> testC = new List<int> { 9, 9, 9 };
            for (int i = 0; i < 4; i++)
            {
                c.Add(i + 1);
            }
            c.AddRange(testMass);
            c.AddRange(testC);
            c.RemoveAt(9);
            c.Remove(3);
            Console.WriteLine("Values:");
            foreach (int item in c)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            c.Sort(true);
            Console.WriteLine("Sorted values:");
            foreach (int item in c)
            {
                Console.Write($"{item} ");
            }
        }
    }
}