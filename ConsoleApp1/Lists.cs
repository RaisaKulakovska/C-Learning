using System;

public class Lists
{
	public Lists()
	{

        static void Main(string[] args)
        {
            double a;
            double b;
            double res = 0;
            string operation;
            bool c = true;

            List<double> resultsList = new List<double>();
            while (c)
            {
                Console.WriteLine("Enter a: ");
                string input1 = Console.ReadLine();
                a = Convert.ToDouble(input1);

                Console.WriteLine("Enter b: ");
                string input2 = Console.ReadLine();
                b = Convert.ToDouble(input2);

                Console.WriteLine("Enter operation: (+,-,*,/) , '0' - breack");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        res = a + b;
                        Console.WriteLine($"{a}+{b}={res}");
                        break;
                    case "-":
                        res = a - b;
                        Console.WriteLine($"{a}-{b}={res}");
                        break;
                    case "*":
                        res = a * b;
                        Console.WriteLine($"{a}*{b}={res}");
                        break;
                    case @"/":
                        if (b != 0)
                        {
                            res = a / b;
                            Console.WriteLine($"{a}/{b}={res}");
                        }
                        else
                        {
                            Console.WriteLine("Division by 0!");
                        }
                        break;

                    case "0":
                        c = false;
                        break;
                    default:
                        Console.WriteLine("Enter correct operation");
                        break;
                }
                resultsList.Add(res);
                Console.WriteLine();
                Console.Write("ResultsList: ");
                foreach (double result1 in resultsList)
                {
                    Console.Write(result1 + ", ");
                }
                Console.WriteLine();


            }
            //int b = int.Parse(input2);
        }  
    }
}
