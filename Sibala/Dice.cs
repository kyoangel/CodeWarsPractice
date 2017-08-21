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
                    if (noPair.Count == 0)
                    {
                        result = DiceType.All.ToString() + pairs[0].ToString();
                    }
                    else
                    {
                        points = noPair.Sum();
                        return (points == 3) ? DiceType.BG.ToString() : noPair.Sum() + DiceType.Points.ToString();
                    }

                    break;
                case 2:
                    points = diceList.Max() * 2;
                    return (points == 12) ? DiceType.EighteenLa.ToString() : points.ToString() + DiceType.Points.ToString();
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
