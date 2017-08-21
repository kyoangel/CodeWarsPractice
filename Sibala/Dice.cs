using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibala
{

    public enum DiceType
    {
        BG,
        NoPoint,
        Points,
        EighteenLa,
        All
    }

    public class Dice
    {
        List<int> diceList = new List<int>();
        public Dice(int p1, int p2, int p3, int p4)
        {
            diceList.Add(p1);
            diceList.Add(p2);
            diceList.Add(p3);
            diceList.Add(p4);
        }

        public string Calculate()
        {
            var points = 0;

            List<int> pairs = diceList.GroupBy(x => x)
                             .Where(g => g.Count() > 1)
                             .Select(g => g.Key)
                             .ToList();

            List<int> noPair = diceList.GroupBy(x => x)
                 .Where(g => g.Count() == 1)
                 .Select(g => g.Key)
                 .ToList();

            var result = "";

            switch (pairs.Count)
            {
                case 0:
                    result = DiceType.NoPoint.ToString();
                    break;
                case 1:
                    result = (noPair.Count == 0) ?
                    DiceType.All.ToString() + pairs[0].ToString() :
                    noPair.Sum() + DiceType.Points.ToString();
                    break;
                case 2:
                    points = diceList.Max() * 2;
                    result = points.ToString() + DiceType.Points.ToString();
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
