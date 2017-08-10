using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDeadAnts
{
    public class FindDeadAnts
    {
        public static int DeadAntCount(string ants)
        {
            if (string.IsNullOrWhiteSpace(ants))
                return 0;

            string deadAntParts = RemoveLiveAnts(ants);
            int heads = deadAntParts.Count(x => x == 'a');
            int bodys = deadAntParts.Count(x => x == 'n');
            int legs = deadAntParts.Count(x => x == 't');

            return Math.Max(Math.Max(heads, bodys), legs);
        }

        private static string RemoveLiveAnts(string ants)
        {
            return ants.Replace("ant", " ");
        }
    }
}
