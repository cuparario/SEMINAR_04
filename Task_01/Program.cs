/* Задайте одномерный массив, заполненный случайными
числами. Определите количество простых чисел в этом
массиве.
Примеры
[1 3 4 19 3] => 3
[4 3 4 1 9 5 21 13] => 3 */

using System;
using System.Reflection.Metadata.Ecma335;

namespace Task_01

{
    public class Program
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("test");
            int [] array = CreateArray(7,0,9);
            Console.WriteLine($"[{Print(array)}]");
            int count = FindSimpleNum(array);
            Console.WriteLine($"The namber of simply numbers is {count}");
        }

        public static int [] CreateArray(int size, int min, int max)
        {
            int [] array = new int[size];
            Random rand = new();
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

        public static int FindSimpleNum(int [] array)
        {
            int count = 0;
            bool flag = true;

            foreach (int item in array)
            {
                if(item == 0 || item == 1) continue;
                if (item == 2)
                {
                    count ++;
                    continue;
                }
                flag = true;
                for (int i = 2; i < item; i++)
                {
                    if (item % i == 0)
                    {
                        flag = false;
                        break;
                    }
                    
                }
                if(flag) count ++;
            }
            return count;
       
        }
      
    }
}