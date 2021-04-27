using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            bool c = true;

            Console.WriteLine("Enter n: ");
            string n_str = Console.ReadLine();
            int n = Convert.ToInt16(n_str);

            List<int> itemsList = new List<int>();

            while (c)
            {
                for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Enter item: ");
                        string it = Console.ReadLine();
                        //int item = int.Parse(it);                
                        int item = Convert.ToInt16(it);

                        itemsList.Add(item);
                        Console.WriteLine();
                    }
                
                Console.Write("ResultsList: ");
                foreach (int item in itemsList)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine();
                }
        }
    }
}
    /*class BaseClass
    {
        public int A;
        protected int B;
        private int c;
    }

    class ChildClass: BaseClass
    {
        public void GetValue()
        {
            Dictionary<string, int>
        }
    }*/
