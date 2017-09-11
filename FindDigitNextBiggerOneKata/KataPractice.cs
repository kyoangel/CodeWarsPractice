using System;
using System.Linq;

namespace FindDigitNextBiggerOneKata
{
    public class KataPractice
    {
        public static long NextBiggerNumber(long n)
        {
            //code me
            var targetStr = n.ToString();
            var length = targetStr.Length;
            var result = "";
            var left = 0;
            var right = 0;
            for (int i = length - 1; i >= 1; i--)
            {
                right = int.Parse(targetStr[i].ToString());
                left = int.Parse(targetStr[i - 1].ToString());
                if (left < right)
                {
                    var min = targetStr.Substring(i).Where(x=> int.Parse(x.ToString())>left).Min();
                    var minIndex = targetStr.LastIndexOf(min);

                     result = targetStr.Remove(minIndex, 1);

                    if (i - 2 >= 0)
                        result = result.Substring(0, i - 1) + min.ToString() + FindMinDigit(result.Substring(i-1));
                    else
                        result = min.ToString() + FindMinDigit(result.Substring(i-1));

                    return long.Parse(result);
                }
            }
            return 0;
        }

        private static string FindMinDigit(string str)
        {
            var result = str.ToCharArray();
            return new string(result.OrderBy(x => x).ToArray());
        }
    }
}
