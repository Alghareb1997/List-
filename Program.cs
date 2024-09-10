using System.Data;

namespace ConsoleApp1
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("This our array : ");
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7); 
            list.Add(8);
             list.Add(9);
            list.Add(10);

            foreach (int i in list) {
                Console.WriteLine(i);
           
            }
            Console.Write("  numbers of item in list is:  ");
            Console.WriteLine(list.Count);
            Console.Write("   Capacity before trimexcess >>   ");
            Console.WriteLine(list.Capacity);
            list.TrimExcess();
            Console.Write("   Capacity after trimexess >>   ");
            Console.WriteLine(list.Capacity);
            Console.Write("  Entre number from list to remove it : ");
            int num=int.Parse(Console.ReadLine());
            list.Remove(num);
            Console.WriteLine(" num {0}  : is removed from list",num);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            int[ ] ints = new int[10];
            Console.WriteLine("  Please entre the count of elements you want to save in array ");
             int numItem = int.Parse(Console.ReadLine());
            for (int i = 0; i < numItem; i++)
            {
                Console.WriteLine("  Please entre element {0} : in array ", i);
                ints[i] =int.Parse(Console.ReadLine());
            }
            for (int i = 0;i < numItem; i++)
            {
                Console.WriteLine("   The {0} :item is {1} : in array ", i, ints[i]);
            }


            Console.ReadLine();










          

        }
    }
}
