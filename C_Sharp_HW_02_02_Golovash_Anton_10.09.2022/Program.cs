using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_02_02_Golovash_Anton_10._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Сжать массив, удалив из него все 0 и, заполнить освободившиеся справа элементы значениями -1
            int[] arr1 = new int[] { 1, 0, 2, 3, 4, 0, 5, 6, 0, 7, 8, 0, 9, 10, 11, 0, 12, 13, 0, 14, 15 };
            Console.WriteLine("1. Сжать массив");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine("удалив из него все 0 и заполнить освободившиеся справа элементы значениями -1");
            int[] arr2 = new int[arr1.Length];
            int arr2Iterator1 = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != 0)
                {
                    arr2[arr2Iterator1] = arr1[i];
                    arr2Iterator1++;
                }
                else if (arr1[i] == 0)
                {
                    continue;
                }
            }
            for (; arr2Iterator1 < arr2.Length; arr2Iterator1++)
            {
                arr2[arr2Iterator1] = -1;
            }
            Console.WriteLine("1. Массив");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine("после удаления из него всех 0 и заполнения освободившихся справа элементов значениями -1");

            //2.Преобразовать массив так, чтобы сначала шли все отрицательные элементы, а потом положительные (0 считать положительным)



            //3.Написать программу, которая предлагает пользователю ввести число и считает, сколько раз это число встречается в массиве.

            //4.В двумерном массиве порядка М на N поменяйте местами заданные столбцы.

            Console.ReadLine();
        }
    }
}
