using System;

public class Dictionaries
{
	public Dictionaries()
	{
		static void Main(string[] args)
		{
            int n, i, k;

            Dictionary<int, string> countries = new Dictionary<int, string>
                {
                    {1, "France"},
                    {2, "England"},
                    {3, "Germany"}
                };
            foreach (var pair in countries)
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);

            Console.WriteLine("Enter n: ");
            string n_str = Console.ReadLine();
            n = Convert.ToInt16(n_str);
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Enter key: ");
                string k_str = Console.ReadLine();
                k = Convert.ToInt16(k_str);

                Console.WriteLine("Enter value: ");
                string v_str = Console.ReadLine();

                countries.Add(k, v_str);
            }

            Console.WriteLine("New Dictionary: ");
            foreach (var pair in countries)
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);

            Console.WriteLine("Enter key, take value: ");
            string k_to_get_str = Console.ReadLine();
            int k_to_get = Convert.ToInt16(k_to_get_str);
            Console.WriteLine("{0} - {1}", k_to_get, countries[k_to_get]);

            Console.ReadKey();
        }
    }
	}
}
