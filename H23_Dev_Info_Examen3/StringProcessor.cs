using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H23_Dev_Info_Examen3
{
    public class StringProcessor
    {
        internal bool StartsWithUpper(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            char firstChar = input[0];
            return char.IsUpper(firstChar);
        }

        public string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public int CountVowels(string input)
        {
            if (string.IsNullOrEmpty(input))
                return -1;

            int count = 0;
            foreach (char c in input)
            {
                if (IsVowel(c))
                    count++;
            }
            return count;
        }

        private bool IsVowel(char c)
        {
            char lowerC = char.ToLower(c);
            return lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u';
        }

        public string ConcatenateStrings(string first, string second)
        {
            if (first == null && second == null)
                return "NULL_STRINGS";
            else
                return first + second;
        }
    }

}
