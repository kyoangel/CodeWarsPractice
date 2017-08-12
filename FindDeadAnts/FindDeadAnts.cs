using System;
using System.Linq;

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

            return GetMaxParts(heads, bodys, legs);
        }

        private static int GetMaxParts(int heads, int bodys, int legs)
        {
            return Math.Max(Math.Max(heads, bodys), legs);
        }

        private static string RemoveLiveAnts(string ants)
        {
            return ants.Replace("ant", " ");
        }
    }
}
