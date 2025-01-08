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
            for (int i = word.Length-1; i >=0; i--)
            {
                result+=word[i];
            }
            return result;
        }
    }
}