using System;

namespace task
{ /* Задача: Написать программу, которая из 
       имеющегося массива строк формирует новый массив из строк,
       длина которых меньше, либо равна 3 символам.
       Первоначальный массив можно ввести с клавиатуры,
       либо задать на старте выполнения алгоритма. */
       
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = {"Hi", ", ", "San", " ", "nigth", "Time", "day", "!"}; 
            string[] array2 = new string[array1.Length];
            GetArray2(array1, array2);     
            PrintArray(array2);                          // Hi, San day!

            string[] GetArray2(string[] arr1, string[] arr2)
            {
               
                int count = 0;
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i].Length <= 3)
                    {
                        arr2[count] = arr1[i];
                        count++;
                    }
                }
                return arr2;
               
            }

           
            void PrintArray(string[] ar)
            {
                 for(int i = 0; i < ar.Length; i++)
                    { 
                       
                        Console.Write($"{ar[i]}"); 
                    }
                           
              
                Console.WriteLine(); 
            }
               
        }
    }
}
