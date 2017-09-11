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



                    //result = targetStr.Substring(0, i - 2) + ;
                    if (i - 2 >= 0)
                        result = result.Substring(0, i - 1) + min.ToString() + FindMinDigit(result.Substring(i-1));
                    else
                        result = min.ToString() + FindMinDigit(result.Substring(i-1));
                    //for (int j = i; j < length - 1; j++)
                    //{
                    //    var result2 = swapChar(result, j + 1, j);
                    //    if (int.Parse(result2) < int.Parse(result))
                    //    {
                    //        return long.Parse(result2);
                    //    }
                    //}

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

        private static string SwapChar(string str, int v, int i)
        {
            var result = str.ToCharArray();
            var temp = result[v];
            result[v] = result[i];
            result[i] = temp;

            return new string(result);
        }
    }
}
