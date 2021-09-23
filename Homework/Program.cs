using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            string[] strArr = { "яблуко", "груша", "слива", "персик", "кавун" };
            string temp;
            Console.WriteLine("Array before:");
            for (int i = 0; i < strArr.Length - 1; i++)
            {
                Console.WriteLine($"{strArr[i]}");
            }

            for (int i = 0; i < strArr.Length - 1; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (string.Compare(strArr[j], strArr[j + 1]) > 0)

                    {
                        temp = strArr[j];
                        strArr[j] = strArr[j + 1];
                        strArr[j + 1] = temp;
                    }

                }
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("Array after:");
            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine($"{strArr[i]}");
            }
            Console.ReadKey();
            Console.WriteLine();
            #endregion

            #region task 2
            string[] arr_word = { "leaf", "oak", "wheat", "meal", "water" };
            //string[] arr_reverse = new string[5];
            string temp_help;
            Console.WriteLine("Before reverse:");
            for (int i = 0; i < arr_word.Length; i++)
            {
                Console.WriteLine(arr_word[i]);
            }
            for (int i = 0, j = arr_word.Length - 1; i < j; i++, j--)
            {
                temp_help = arr_word[i];
                arr_word[i] = arr_word[j];
                arr_word[j] = temp_help;

            }
            Console.WriteLine("===============");
            Console.WriteLine("After reverce:");
            for (int k = 0; k < arr_word.Length; k++)
            {
                Console.WriteLine(arr_word[k]);
            }

            #endregion

            #region task3

            string text = "winter .e . ..";
            Console.WriteLine("Text:");
            Console.WriteLine(text);

            //індекс першої крапки.
            int indexUP = text.IndexOf('.');
            //індекс другої крапки
            int indexClose = text.IndexOf('.', indexUP + 1);

            string res = text.Substring(0, indexClose).Trim();
            string str = text.Substring(indexClose, text.Length - indexClose);

            //результуюча строчка.
            string str_res = res + str;
            Console.WriteLine(str_res);

            #endregion

            #region task4

            Console.WriteLine("Enter the word:");
            string text_word = Console.ReadLine();
            string result = text_word.Replace(" ", string.Empty);
            string reverce = string.Empty;
            result = result.ToLower();
            int index = result.Length - 1;
            for (int i = index; i >= 0; i--)
            {
                reverce += result[i];
            }
            //Console.WriteLine(reverce);
            Console.WriteLine(reverce != result ? "Not palindrom" : "Palindrom");

            #endregion

            #region task5

            string[] stroka = { "This", "is", "my", "homework" };
            int len = stroka.Length;
            for (int i = 0; i < len; i++)
            {
                Console.Write(stroka[i] + ' ');
            }
            Console.WriteLine();
            Console.WriteLine("Enter number of word");
            int indexa = int.Parse(Console.ReadLine());
            Console.WriteLine(stroka[indexa - 1].ToUpper()[0]);

            #endregion

            #region task6
            string[] strok = { "This", "is", "great", "homework" };
            int maxLen = 0;
            int leng = strok.Length;

            for (int i = 0; i <= leng - 1; i++)
            {
                Console.WriteLine(strok[i] + ' ' + strok[i].Length);

                Console.WriteLine(strok[i].Length);
                if (strok[i].Length > maxLen)
                {
                    maxLen = strok[i].Length;

                }

            }

            Console.WriteLine("Enter len:");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine(w <= maxLen ? "" : "Error");
            Console.WriteLine();
            for (int i = 0; i < leng; i++)
            {
                if (w == strok[i].Length)
                {
                    Console.WriteLine(strok[i]);
                    String s2 = strok[i].Substring(0, strok[i].Length - 3);
                    Console.WriteLine(s2);
                    for (int p = 0; p < 3; p++)
                    {
                        s2 += "$";
                    }
                    Console.WriteLine(s2);
                }
            }


            #endregion

            #region task7


            string str1 = "Ertf jio dgy Df SShh WWWWgghc";
            str1 = str1.Replace(" ", "");
            int count_up = 0;
            int count_low = 0;

            int l = str1.Length;
            for (int i = 0; i < l; i++)
            {
                if (str1[i] == str1.ToUpper()[i])
                {
                    count_up++;
                }
                else
                {
                    count_low++;
                }

            }
            Console.WriteLine($"Upper letter: { (count_up * 100) / l} %");
            Console.WriteLine($"Lower letter: { (count_low * 100) / l} %");
            #endregion

            #region task8

            string texts = "To be or not to be";
            string insert_text = " yes ";
            Console.WriteLine("Enter index for insert another string:");
            int index_ins = int.Parse(Console.ReadLine());
            texts = texts.Insert(index_ins, insert_text);
            Console.WriteLine(texts);

            #endregion

            #region task9

            string text3 = "Frtdgv** gdgd**svvs**jjhc";
            Console.WriteLine("Enter symbols from string:");
            string r = Console.ReadLine();
            Console.WriteLine("Enter new symbols:");
            string y = Console.ReadLine();
            text3 = text3.Replace(r, y);
            Console.WriteLine(text3);

            #endregion

            #region task10
            const int row = 3;
            const int col = 4;
            int[] n = new int[5];
            int[] c = new int[5];
            bool horizont = false;
            int pos = 0;
            string[,] arr = new string[row, col] {
                {"m","i","l","k"},
                {"r","e","s","t"},
                {"u","a","w","x"}
            };
            Console.WriteLine("Enter word:");

            string word_test = Console.ReadLine();

            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; j++)
                {
                    for (int x = 0; x < word_test.Length; x++)
                    {
                        string item = arr[i, j];

                        if (arr[i, j].Contains(word_test[x]))
                        {
                            Console.Write($"{item}");
                            n[pos] = i;
                            c[pos] = j;
                            pos++;

                        }

                    }


                }
            }

            for (int i = 0; i < 2; i++)
            {
                if (n[i] == n[i + 1])
                {
                    horizont = true;
                }

            }

            Console.WriteLine($"\nStart from {n[0]} row and {c[0]} col");
            Console.WriteLine(horizont ? "horiz" : "vert");
            #endregion

            #region task11
            string str4 = " hb dgd gggdv dbdvd dii ii ";
            str4 = str4.Trim().Replace(" ", "*");
            Console.WriteLine(str4);
            #endregion

            #region task12
            int maxLeng = 0;
            string str6 = string.Empty;
            string str5 = "fdrfaa hfhfas sagd rtrtrtaa";
            Console.WriteLine($"Before:{str5}");
            string[] words = str5.Split(new char[] { ' ' });
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maxLeng)
                {
                    maxLeng = words[i].Length;
                    str6 = words[i];
                }
            }
            str6 = str6.Replace("a", "b");
            Console.WriteLine($"After:{str6}");
            #endregion

            #region task13
            string str7 = "asd898 tryt95s 1,2 g84n!!.132";
            Console.WriteLine($"Before: {str7}");

            string str_digit = string.Empty;
            string str_letter = string.Empty;
            string str_punt = string.Empty;
            List<double> ff = new List<double>();
            double drib = 0;

            string punkt = ".!?";
            foreach (var item in str7)
            {
                if (char.IsDigit(item))
                {
                    str_digit += item;
                }
                if (char.IsLetter(item))
                {
                    str_letter += item;
                }
                foreach (char p in punkt)
                {
                    if (item == p)
                    {
                        str_punt += item;
                    }
                }

            }

            string[] wor = str7.Split(new char[] { ' ' });
            for (int i = 0; i < wor.Length; i++)
            {
                if (wor[i].Contains(","))
                {
                    Console.WriteLine(wor[i]);
                    drib = Convert.ToDouble(wor[i]);
                    ff.Add(drib);
                }
            }
            Console.WriteLine(str_digit);
            Console.WriteLine(str_letter);
            Console.WriteLine(str_punt);
            foreach (var items in ff)
            {
                Console.WriteLine(items);
            }

            #endregion

            #region task14
            string str8 = "Frt fsfsssss ghty vg ddddddddd ";
            string[] words_chars = str8.Split(new char[] { ' ' });
            string[] results = new string[20];
            int poss = 0;
            for (int i = 0; i < words_chars.Length; i++)
            {
                if (words_chars[i].Length > 5)
                {                   
                    results[poss] += words_chars[i]+" ";
                    poss++;                   
                    
                }               
            }

            string result_new = String.Concat(results);
            Console.WriteLine(result_new);
           
            #endregion
        }
    }
}
