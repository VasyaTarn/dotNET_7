using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Дана строка символов. Необходимо проверить, является ли эта строка палиндромом.

            Console.Write("Your string:");
            string userStr = Console.ReadLine();
            bool poli = true;

            for (int i = 0; i < userStr.Length / 2; i++)

                if (userStr[i] != userStr[userStr.Length - i - 1])
                    poli = false;

            if (poli)
            {
                Console.WriteLine("String is a palindrome");
            }
            else
            {
                Console.WriteLine("String is not a palindrome");
            }

            Console.WriteLine();
            #endregion

            #region 2. Написать программу, подсчитывающую количество слов, гласных и согласных букв в строке, введёной пользователем.

            Console.Write("Your string:");
            string userStr_2 = Console.ReadLine();
            char[] vow = { 'a', 'e', 'i', 'o', 'u', 'y' };
            char[] cons = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };

            int nSym = 0;
            int nWord = 0;
            int nVowel = 0;
            int nConsonant = 0;
            int nPunctuation = 0;
            int nNumbers = 0;
            int nOther = 0;

            userStr_2 = userStr_2.ToLowerInvariant();

            for (int i = 0; i < userStr_2.Length - 1; i++)
            {
                if (char.IsLetter(userStr_2[i]) && (userStr_2[i + 1] == ' ' || userStr_2[i + 1] == ',' || userStr_2[i + 1] == '!' || userStr_2[i + 1] == '?' || userStr_2[i + 1] == '.' || userStr_2[i + 1] == ':' || userStr_2[i + 1] == ';' || userStr_2[i + 1] == '(' || userStr_2[i + 1] == ')' || userStr_2[i + 1] == '"'))
                    nWord++;
                else if (char.IsLetter(userStr_2[i]))
                {
                    if (vow.Contains(userStr_2[i]))
                    {
                        nVowel++;
                    }
                    else if (cons.Contains(userStr_2[i]))
                    {
                        nConsonant++;
                    }

                }
                else if (userStr_2[i] == ',' || userStr_2[i] == '!' || userStr_2[i] == '?' || userStr_2[i] == '.' || userStr_2[i] == ':' || userStr_2[i] == ';' || userStr_2[i] == '(' || userStr_2[i] == ')' || userStr_2[i] == '"')
                    nPunctuation++;
                else if (char.IsDigit(userStr_2[i]) && (userStr_2[i + 1] == ' ' || userStr_2[i + 1] == '!' || userStr_2[i + 1] == '?' || userStr_2[i + 1] == '.' || userStr_2[i + 1] == ':' || userStr_2[i + 1] == ';' || userStr_2[i + 1] == '(' || userStr_2[i + 1] == ')' || userStr_2[i + 1] == '"'))
                    nNumbers++;
                else
                    nOther++;
            }


            if (char.IsLetter(userStr_2[userStr_2.Length - 1]))
            {
                nWord++;
                if (vow.Contains(userStr_2[userStr_2.Length - 1]))
                {
                    nVowel++;
                }
                else if (cons.Contains(userStr_2[userStr_2.Length - 1]))
                {
                    nConsonant++;
                }
            }
            else if (char.IsDigit(userStr_2[userStr_2.Length - 1]))
                nNumbers++;
            else if (userStr_2[userStr_2.Length - 1] == ',' || userStr_2[userStr_2.Length - 1] == '!' || userStr_2[userStr_2.Length - 1] == '?' || userStr_2[userStr_2.Length - 1] == '.' || userStr_2[userStr_2.Length - 1] == ':' || userStr_2[userStr_2.Length - 1] == ';' || userStr_2[userStr_2.Length - 1] == '(' || userStr_2[userStr_2.Length - 1] == ')' || userStr_2[userStr_2.Length - 1] == '"')
                nPunctuation++;
            nSym = userStr_2.Length;

            Console.Write("Symbols:");
            Console.WriteLine(nSym);
            Console.Write("Words:");
            Console.WriteLine(nWord);
            Console.Write("Vowels:");
            Console.WriteLine(nVowel);
            Console.Write("Consonants:");
            Console.WriteLine(nConsonant);
            Console.Write("Punctuation marks:");
            Console.WriteLine(nPunctuation);
            Console.Write("Numbers:");
            Console.WriteLine(nNumbers);
            Console.Write("Other symbols:");
            Console.WriteLine(nOther);

            Console.WriteLine();
            #endregion

            #region 3. Написать программу, проверяющую, является ли одна строка анаграммой для другой строки

            Console.Write("Str#1:");
            string str1 = Console.ReadLine();
            Console.Write("Str#2:");
            string str2 = Console.ReadLine();
            if (str1 != str2)
            {
                char[] ch1 = new char[str1.Length];
                char[] ch2 = new char[str2.Length];

                int temp1 = 0;
                int temp2 = 0;

                for (int i = 0; i < str1.Length; i++)
                {
                    if (char.IsLetter(str1[i]))
                    {
                        ch1[temp1] = str1[i];
                        temp1++;
                    }
                }

                for (int i = 0; i < str2.Length; i++)
                {
                    if (char.IsLetter(str2[i]))
                    {
                        ch2[temp2] = str2[i];
                        temp2++;
                    }
                }

                Array.Resize(ref ch1, temp1);
                Array.Resize(ref ch2, temp2);

                //foreach (char i in ch1)
                //{
                //    Console.Write(i);
                //}
                //Console.WriteLine();
                //foreach (char j in ch2)
                //{
                //    Console.Write(j);
                //}

                if (ch1.Length == ch2.Length)
                {
                    bool eq = false;
                    int tmp = 0;
                    for (int i = 0; i < ch1.Length; i++)
                    {
                        if (ch1[i] == ch2[i])
                            tmp++;
                    }
                    if (tmp == ch1.Length)
                        eq = true;

                    if (eq == false)
                    {
                        Array.Sort(ch1);
                        Array.Sort(ch2);
                        bool eq2 = false;
                        int tmp2 = 0;
                        for (int i = 0; i < ch1.Length; i++)
                        {
                            if (ch1[i] == ch2[i])
                                tmp2++;
                        }
                        if (tmp2 == ch1.Length)
                            eq2 = true;
                        if (eq2 == true)
                            Console.WriteLine("It's an anagram");
                        else
                            Console.WriteLine("It's not an anagram");
                    }
                    else
                        Console.WriteLine("It's not an anagram");
                }
                else
                    Console.WriteLine("It's not an anagram");


            }
            else
                Console.WriteLine("Strings are equal");


            Console.WriteLine();
            #endregion
        }
    }
}

