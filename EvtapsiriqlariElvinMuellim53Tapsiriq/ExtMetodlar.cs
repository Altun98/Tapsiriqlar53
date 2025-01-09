using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtapsiriqlariElvinMuellim53Tapsiriq
{
    public static class ExtMetodlar
    {
        public static int GetnumberOfLetters(this string word, char letter)
        {
            int count = 0;
            char[] chars = word.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == letter)
                {
                    count++;
                }
            }
            return count;
        }
        public static int GetUpperLettersCount(this string word)
        {
            int count = 0;
            char[] chars = word.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 'A' && chars[i] <= 'Z')
                {
                    count++;
                }
            }
            return count;
        }
        public static string GetReversString(this string word)
        {
            string result = string.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                result += word[i];
            }
            return result;
        }
        public static List<int> GetASCII(this string word)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < word.Length; i++)
            {
                result.Add((int)word[i]);
            }
            return result;
        }
        public static bool GetControlLatter(this string word, char latter)
        {
            bool _controll = false;
            char[] chars = word.ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                if ((char)word[i] == latter)
                {
                    _controll = true;
                }
            }
            return _controll;
        }
        public static string WordlatterDelete(this string word, char latter)
        {
            string result = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                if ((char)word[i]!=latter)
                {
                    result += word[i].ToString();
                }
            }
            return result;
        }
        public static List<Char> GetBigLatter(this string word)
        {
            List<char> result = new List<char>();
            char[] chars = word.ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                if (chars[i]>='A' && chars[i]<='Z')
                {
                    result.Add(chars[i]);
                }
            }
            return result;
        }

    }
}