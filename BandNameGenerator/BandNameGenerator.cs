﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandNameGenerator
{
    public class BandNameGenerator
    {
        public static string GenerateBandName(string str)
        {
            // Happy coding
            if (string.IsNullOrEmpty(str))
                throw new ArgumentException("input string should not be null or empty"); ;

            var result = "";
            var start = str[0].ToString();
            var end = str[str.Length-1].ToString();
            if (start.Equals(end))
            {
                result = str[0].ToString().ToUpper() + str.Substring(1, str.Length - 1) + str;
            }
            else
            {
                result = "The " + str[0].ToString().ToUpper() + str.Substring(1,str.Length -1);
            }

            return result;
        }
    }
}
