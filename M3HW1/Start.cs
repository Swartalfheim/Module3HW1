namespace M3HW1
{
    public class Start : GenericList<string>
    {
        public void Run()
        {
            Console.WriteLine("Select the option of what you want to do by writing the number of the action and pressing enter, after the end of the action, you can choose another or the same:" +
                "\n1) Enter data from the keyboard" +
                "\n2) add an array and transfer the data from it to the list" +
                "\n3) delete data by name" +
                "\n4) delete data by number" +
                "\n5) sort data" +
                "\n6) output data" +
                "\n7)finish all operations");
            while (true)
            {
                string? task = Console.ReadLine();
                if (task == "1")
                {
                    Console.WriteLine("Enter the values separating them with enter, when you have finished entering then enter: \"00\"");
                    while (true)
                    {
                        string? a = Console.ReadLine();
                        if (a == "00")
                        {
                            break;
                        }
                        else
                        {
                            Added(a);
                        }
                    }
                }

                if (task == "2")
                {
                    Console.WriteLine("enter the number of characters in the array");
                    int num = Convert.ToInt32(Console.ReadLine());
                    string[] a = new string[num];
                    Console.WriteLine("enter each character in the array, separating them with enter");
                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i] = Console.ReadLine();
                    }

                    AddedArray(a);
                }

                if (task == "3")
                {
                    Console.WriteLine("enter the value you want to delete");
                    string? a = Console.ReadLine();
                    Removal(a);
                    Console.WriteLine("True");
                }

                if (task == "4")
                {
                    Console.WriteLine("enter the index of the value you want to delete");
                    int a = Convert.ToInt32(Console.ReadLine());
                    RemovalAt(a);
                }

                if (task == "5")
                {
                    Console.WriteLine("list sorted");
                    Sorted();
                }

                if (task == "6")
                {
                    PrintInfo();
                }

                if (task == "7")
                {
                    Console.WriteLine("Thanks for using this app.");
                    break;
                }

                Console.WriteLine("/////////////////////////////////////////");
            }
        }
    }
}
