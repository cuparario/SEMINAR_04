/* Задайте массив из N случайных целых чисел (N вводится с
клавиатуры).
Найдите количество чисел, которые оканчиваются на 1 и
делятся нацело на 7.
Пример
[1 5 11 21 81 4 0 91 2 3] => 2 */

using System;

namespace Task_02
{
    public class Task_02
    {
        public static void Main(string [] args)
        {
            int size = Convert.ToInt32 (Console.ReadLine());
            int [] array = CreateArray (size, 21, 0);
            Console.WriteLine(Print(array));
            int count = Dev7End1(array);
            Console.WriteLine (count);
        
        }
    
        public static int [] CreateArray (int size, int max, int min)
        {
        int [] array = new int [size];
        Random rand = new ();
        for (int i = 0; i < size; i++)
            {
            array[i] = rand.Next(min, max + 1);
            }

        return array;
        }
        public static string Print(int [] array)
        {
            string result = string.Join(", ", array);
            return result;
        }
        public static int Dev7End1 (int [] array)
        {
            int count = 0;
            foreach (int item in array)
            {
                if ((item % 7) == 0 && (item % 10 == 1))
                {
                    count ++;
                }
            
            }
            return count;
        }
    }
}

