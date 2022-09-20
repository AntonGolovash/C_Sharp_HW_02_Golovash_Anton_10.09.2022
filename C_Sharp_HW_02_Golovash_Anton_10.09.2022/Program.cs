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
            //1. Дана строка. Вывести строку, содержащую те же символы, но расположенные в обратном порядке.
            
            string str1 = "abcdefghijklmn";
            Console.WriteLine($"1. Дана строка {str1}.\nВывести строку, содержащую те же символы, но расположенные в обратном порядке.");
            Console.WriteLine(str1.Reverse()); // не могу понять что здесь возвращает функция
            Console.WriteLine();

            //2. Дана строка.
            //Вывести строку, содержащую символы данной строки, между которыми вставлено по одному пробелу.

            string str2 = "abcdefghijklmn";
            Console.WriteLine($"2. Дана строка {str2}.\nВывести строку, содержащую символы данной строки, между которыми вставлено по одному пробелу.");
            char[] arr2 = str2.ToCharArray();

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            //3. Дана строка и целое число N (> 0).
            //Вывести строку, содержащую символы данной строки, между которыми вставлено по N символов «*» (звездочка).

            string str3 = "abcdefghijklmn";
            const int N = 5;
            Console.WriteLine($"3. Дана строка {str3} и целое число N = {N}. \nВывести строку, содержащую символы данной строки, между которыми вставлено по N символов «*» (звездочка).");
            char[] arr3 = str3.ToCharArray();

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i]);
                for (int j = 0; j < N; j++)
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            //4. Дана строка.
            //Подсчитать количество содержащихся в ней цифр.

            string str4 = "a1bc2de3fg4hi5jk6lm7n";
            Console.WriteLine($"4. Дана строка {str4}\nПодсчитать количество содержащихся в ней цифр.");
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

            string str5 = "aAbcCdeEfgGhiIjkKlmMn";
            Console.WriteLine($"5. Дана строка {str5}\nПодсчитать количество содержащихся в ней прописных латинских букв.");
            char[] arr5 = str5.ToCharArray();
            int number_of_uppercase_Latin_letters = 0;

            for (int i = 0; i < arr5.Length; i++)
            {
                if (65 <= (int)(arr5[i]) && (int)(arr5[i]) <= 90)
                {
                    ++number_of_uppercase_Latin_letters;
                }
            }

            Console.WriteLine($"Количество прописных латинских букв в строке - {number_of_uppercase_Latin_letters}");
            Console.WriteLine();

            //6. Дана строка.
            //Подсчитать общее количество содержащихся в ней строчных латинских и кириллических букв.

            string str6 = "asdfghjячсмитё";
            Console.WriteLine($"6. Дана строка {str6}\nПодсчитать общее количество содержащихся в ней строчных латинских и кириллических букв.");
            char[] arr6 = str6.ToCharArray();
            int number_of_lowercase_Latin_letters = 0;
            int number_of_lowercase_Cyrillic_letters = 0;

            for (int i = 0; i < arr6.Length; i++)
            {
                if (97 <= (int)(arr6[i]) && (int)(arr6[i]) <= 122)
                {
                    ++number_of_lowercase_Latin_letters;
                }

                if (1072 <= (int)(arr6[i]) && (int)(arr6[i]) <= 1103 || (int)(arr6[i]) == 1105)
                {
                    ++number_of_lowercase_Cyrillic_letters;
                }
            }

            Console.WriteLine($"Общее количество содержащихся в строке строчных латинских и кириллических букв - " +
                $"{number_of_lowercase_Latin_letters + number_of_lowercase_Cyrillic_letters}");

            Console.WriteLine();

            //7. Дана строка.
            //Преобразовать в ней все прописные латинские буквы в строчные.

            string str7 = "aAbcCdeEfgGhiIjkKlmMn";
            Console.WriteLine($"7. Дана строка {str7}\nПреобразовать в ней все прописные латинские буквы в строчные.");
            char[] arr7 = str7.ToCharArray();

            for (int i = 0; i < arr7.Length; i++)
            {
                if (65 <= (int)(arr7[i]) && (int)(arr7[i]) <= 90)
                {
                    arr7[i] += (char)32;
                }
            }

            Console.WriteLine("Строка с преобразованными в ней прописными латинскими буквами в строчные - ");
            Console.WriteLine(arr7);
            Console.WriteLine();

            //8. Дана строка.
            //Преобразовать в ней все строчные буквы (как латинские, так и русские) в прописные.

            string str8 = "aAsSdDfFgGhHjJяЯчЧсСмМиИтТёЁ";
            Console.WriteLine($"8. Дана строка {str8}\nПреобразовать в ней все строчные буквы (как латинские, так и русские) в прописные.");
            char[] arr8 = str8.ToCharArray();

            for (int i = 0; i < arr8.Length; i++)
            {
                if (97 <= (int)(arr8[i]) && (int)(arr8[i]) <= 122)
                {
                    arr8[i] -= (char)32;
                }

                if (1072 <= (int)(arr8[i]) && (int)(arr8[i]) <= 1103)
                {
                    arr8[i] -= (char)32;
                }

                if ((int)(arr8[i]) == 1105)
                {
                    arr8[i] -= (char)80;
                }

            }

            Console.WriteLine("Строка с преобразованными в ней прописными латинскими и кириллическими буквами в строчные - ");
            Console.WriteLine(arr8);
            Console.WriteLine();

            //9. Дана строка.
            //Преобразовать в ней все строчные буквы(как латинские, так и русские) в прописные, а прописные - в строчные.

            //10. Дана строка.
            //Если она представляет собой запись целого числа, то вывести 1.
            //если вещественного(с дробной частью) вывести 2;
            //если строку нельзя преобразовать в число, то вывести 0.
            //Считать, что дробная часть вещественного числа отделяется от
            //его целой части десятичной точкой

            //11. Дано целое положительное число. Вывести символы, изображающие цифры этого числа (в порядке слева направо).

            int number11 = 65;
            Console.WriteLine($"11. Дано целое положительное число {number11}\nВывести символы, изображающие цифры этого числа (в порядке слева направо).");
            Console.WriteLine((char)number11);
            Console.WriteLine();

            //12. Дано целое положительное число. Вывести символы, изображающие цифры этого числа(в порядке справа налево).

            //13. Дано целое число N(> 0) и строка S.
            //Преобразовать строку S в строку длины и следующим образом:
            //если длина строки S больше N, то отбросить первые символы,
            //если длина строки S меньше N, то в ее начало добавить символы «.» (точка).



            //14. Даны целые положительные числа N1 и N2 и строки S1 и S2.
            //Получить из этих строк новую строку, содержащую первые N1 символов строки S1
            //и последние N2 символов строки S2(в указанном порядке).
            
            int firstCharacters = 5;
            int lastCharacters = 7;
            string str14 = "abcdefgh";
            string str141 = "opqrstuxyz";
            Console.WriteLine($"14. Даны целые положительные числа {firstCharacters} и {lastCharacters}\n" +
                $"и строки {str14} и {str141}\n" +
                $"Получить из этих строк новую строку, содержащую первые {firstCharacters} символов строки {str14}\n" +
                $"и последние {lastCharacters} символов строки {str141} (в указанном порядке)");
            Console.WriteLine();
            char[] arr14 = str14.ToCharArray();
            char[] arr141 = str141.ToCharArray();
            char[] tempArr = new char[firstCharacters + lastCharacters];
            for (int i = 0; i < firstCharacters; i++)
            {
                tempArr[i] = arr14[i];
            }
            int iterator = str141.Length - lastCharacters;
            for (int j = firstCharacters; j < tempArr.Length; j++)
            {
                tempArr[j] = arr141[iterator];
                ++iterator;
            }
            Console.WriteLine($"14. {firstCharacters} первых символов первой строки и\n" +
                $"{lastCharacters} последних символов второй строки образуют новую строку");
            Console.WriteLine(tempArr);
            Console.WriteLine();

            //15. Дан символ СHAR и строка str15. Удвоить каждое вхождение символа СHAR в строку str15.

            const char CHAR15 = 'r';
            string str15 = "orpqrsturxyrz";
            Console.WriteLine($"15. Дан символ {CHAR15} и строка {str15}. Удвоить каждое вхождение символа {CHAR15} в строку {str15}.");
            char[] arr15 = str15.ToCharArray();
            int entry15 = 0;
            for (int i = 0; i < str15.Length; i++)
            {
                if (str15[i] == CHAR15)
                {
                    ++entry15;
                }
            }
            char[] arr151 = new char[str15.Length + entry15];
            int arr151Iterator = 0;
            for (int i = 0; i < arr15.Length; i++)
            {
                if (arr15[i] == CHAR15)
                {
                    arr151[arr151Iterator++] = arr15[i];
                    arr151[arr151Iterator++] = CHAR15;
                }
                else
                {
                    arr151[arr151Iterator++] = arr15[i];
                }
            }
            Console.WriteLine("15. Новая строка");
            Console.WriteLine(arr151);
            Console.WriteLine();

            //16. Дан символ С и строки S, S0. Перед каждым вхождением символа С в строку S вставить строку S0
               
            const char CHAR16 = 'r';
            string str16 = "orpqrsturxyrz";
            string str161 = "AAA";

            Console.WriteLine($"16. Дан символ {CHAR16} и строки {str16} и {str161}.\n" +
                $"Перед каждым вхождением символа {CHAR16} в строку {str16} вставить строку {str161}");
            char[] arr16 = str16.ToCharArray();
            char[] arr161 = str161.ToCharArray();
            int entry16 = 0;
            for (int i = 0; i < str15.Length; i++)
            {
                if (str16[i] == CHAR16)
                {
                    ++entry16;
                }
            }
            char[] resultArr16 = new char[str16.Length + (str161.Length * entry16)];
            int resultArrIterator = 0;
            for (int i = 0; i < arr16.Length; i++)
            {
                if (arr16[i] == CHAR16)
                {
                    for (int j = 0; j < arr161.Length; j++)
                    {
                        resultArr16[resultArrIterator++] = arr161[j];
                    }
                    resultArr16[resultArrIterator++] = arr16[i];
                }
                else
                {
                    resultArr16[resultArrIterator++] = arr16[i];
                }
            }
            Console.WriteLine("16. Новая строка");
            Console.WriteLine(resultArr16);
            Console.WriteLine();

            //17. Дан символ С и строки S, S: После каждого вхождения символа С в строку S вставить строку S0.

            //18. Даны строки S и So. Проверить, содержится ли строка 5, в строке S. Если содержится, то вывести Тгuе, если не содержится, то вывести False

            //19. Даны строки S и So. Найти количество вхождений строки So в строку S.

            //20. Даны строки S и So. Удалить из строки S первую подстроку, совпадающую с So: Если совпадающих подстрок нет, то вывести строку S без изменений

            //21. Даны строки S и So. Удалить из строки S последнюю подстроку, совпадающую с So. Если совпадающих подстрок нет, то вывести строку S без изменений.

            //22. Даны строки S и So. Удалить из строки S все подстроки, совпадающие с S0. Если совпадающих подстрок нет, то вывести строку S без изменений.

            //23. Даны строки S, S и S. Заменить в строке S первое вхождение строки S, на строку S2.

            //24. Даны строки S.S, и Sy. Заменить в строке S последнее вхождение строки S, на строку Sz.

            //25. Даны строки S.S и S2.Заменить в строке S все вхождения строки S, на строку Sz

            Console.ReadLine();

        }
    }
}
