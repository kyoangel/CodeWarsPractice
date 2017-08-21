using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibala
{

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

            return "NoPoint";
        }
    }
}
