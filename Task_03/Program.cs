/* Заполните массив на N (вводится с консоли, не более 8)
случайных целых чисел от 0 до 9.
Сформируйте целое число, которое будет состоять из цифр из
массива. Старший разряд числа находится на 0-м индексе,
младший – на последнем.
Пример
[1 3 2 4 2 3] => 132423
[2 3 1] => 231 */

using System;

namespace Task_03
{
    public class Program
    {
        public static void Main(string [] arg)
        {
            int size = EnterNumber();
            int [] array = CreateArray(size,0,3);
            Console.WriteLine(Print(array));
            int newNumber = NewNumber(array);
            Console.WriteLine($"Целое число, состоящее из цифр массива: {newNumber}");
        }
        public static int EnterNumber()
        {   
            int number = 0;
            bool validInput = false;
            
            while (!validInput)
            {
                try
                {
                    Console.Write("Введите число: ");
                    string input = Console.ReadLine();
                    number = int.Parse(input);
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Введите корректное число");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка! Введено слишком большое или слишком маленькое число");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                }
            }
            Console.WriteLine($"Введеное число: {number}");
            return number;           
        }   
                 
        public static int [] CreateArray(int size, int min, int max)
        {
            int [] array = new int [size];
            Random random = new();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(min, max + 1);
            }
            return array;
        }  

        public static string Print(int [] array)
        {
            string result = string.Join(", ", array);
            return result;
        }
        
        public static int NewNumber(int [] array)
        {
           int newNumber = 0;
           for (int i = 0; i < array.Length; i++)
           {
            newNumber += array[i] * (int)Math.Pow(10, array.Length - 1 - i);
           }
           return newNumber;
        }
        
    
    }    
}
