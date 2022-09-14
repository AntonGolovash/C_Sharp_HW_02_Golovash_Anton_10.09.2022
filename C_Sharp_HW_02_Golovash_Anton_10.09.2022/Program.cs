using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_02_Golovash_Anton_10._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Дана строка. Вывести строку, содержащую те же символы,
            //но расположенные в обратном порядке.
            
            string str1 = "abcdefghijklmn";
            str1.Reverse();

            Console.WriteLine();

            //2. Дана непустая строка S.
            //Вывести строку, содержащую символы строки S,
            //между которыми вставлено по одному пробелу.

            string str2 = "abcdefghijklmn";
            char[] arr2 = str2.ToCharArray();

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }

            Console.WriteLine();

            //3. Дана непустая строка S и целое число N(> 0).
            //Вывести строку, содержащую символы строки S,
            //между которыми вставлено по N символов «*» (звездочка).

            string str3 = "abcdefghijklmn";
            char[] arr3 = str3.ToCharArray();

            const int N = 5;

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i]);
                for (int j = 0; j < N; j++)
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine();

            //4. Дана строка.
            //Подсчитать количество содержащихся в ней цифр.

            string str4 = "a1bc2de3fg4hi5jk6lm7n";
            char[] arr4 = str4.ToCharArray();

            int number_of_digits_in_string = 0;
            for (int i = 0; i < arr4.Length; i++)
            {
                if (48 <= (int)(arr4[i]) && (int)(arr4[i]) <= 57)
                {
                    ++number_of_digits_in_string;
                }
            }
            Console.WriteLine($"Количество цифр в строке - {number_of_digits_in_string}");

            Console.WriteLine();

            //5. Дана строка.
            //Подсчитать количество содержащихся в ней прописных латинских букв.

            //6. Дана строка.
            //Подсчитать общее количество содержащихся в ней строчных латинских и русских букв.

            //7. Дана строка.
            //Преобразовать в ней все прописные латинские буквы в строчные.

            //8. Дана строка.
            //Преобразовать в ней все строчные буквы(как латинские, так и русские) в прописные.

            //9. Дана строка.
            //Преобразовать в ней все строчные буквы(как латинские, так и русские) в прописные,
            //а прописные - в строчные.

            //10. Дана строка.
            //Если она представляет собой запись целого числа, то вывести 1.
            //если вещественного(с дробной частью) вывести 2;
            //если строку нельзя преобразовать в число, то вывести 0.
            //Считать, что дробная часть вещественного числа отделяется от
            //его целой части десятичной точкой

            Console.ReadLine();

        }
    }
}
