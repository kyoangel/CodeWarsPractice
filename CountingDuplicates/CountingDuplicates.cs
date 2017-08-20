﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingDuplicates
{
    public class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            if (string.IsNullOrWhiteSpace(str) || str.Length == 1)
                return 0;

            int length = str.Length;
            str = str.ToLower();

            Dictionary<char, int> letterCount = PrepareLetterCount(str, length);

            return CalculateDuplicateLetters(letterCount);
        }

        private static int CalculateDuplicateLetters(Dictionary<char, int> letterCount)
        {
            var result = 0;

            foreach (var value in letterCount.Values)
            {
                if (value > 0)
                {
                    result += 1;
                }
            }

            return result;
        }

        private static Dictionary<char, int> PrepareLetterCount(string str, int length)
        {
            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            for (int i = 0; i < length; i++)
            {
                if (!letterCount.ContainsKey(str[i]))
                {
                    letterCount.Add(str[i], 0);
                }
                else
                {
                    letterCount[str[i]] += 1;
                }
            }

            return letterCount;
        }
    }
}
