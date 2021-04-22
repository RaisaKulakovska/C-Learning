using System;

namespace WorkWithMassives
{
    class Arrays
    {
        static void Main(string[] args)
        {
            //изменим порядок элементов и размер массива:
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            // расположим в обратном порядке
            Array.Reverse(numbers);

            // уменьшим массив до 4 элементов
            Array.Resize(ref numbers, 4);

            foreach (int number in numbers)
            {
                Console.Write($"{number} \t");
            }
            //4	3	2	1
            //------------------------------------

            //Метод Copy копирует часть одного массива в другой:
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int[] numbers2 = new int[5];

            // копируем из numbers с 2-го индекса 5 элементов 
            // и поместим их в массив numbers2, начиная с 0-го индекса
            Array.Copy(numbers, 2, numbers2, 0, 5);

            foreach (int number in numbers2)
            {
                Console.Write($"{number} \t");
            }
            //-2	-1	0	1	2
            //--------------------------------

            //Отсортируем массив с помощью метода Sort():

            int[] numbers = { -3, 10, 0, -5, 12, 1, 22, 3 };

            Array.Sort(numbers);

            foreach (int number in numbers)
            {
                Console.Write($"{number} \t");
            }
            //-5  -3  0  1  3  10  12  22


        }
    }
}
