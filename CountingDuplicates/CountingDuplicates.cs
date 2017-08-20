using System;
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

            return str.GroupBy(x => char.ToLower(x)).Where(g => g.Count() > 1).Select(r => r.Key).Count();
        }
    }
}
