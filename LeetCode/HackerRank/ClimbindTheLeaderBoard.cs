using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.HackerRank
{
    internal partial class Questions
    {
        public static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player)
        {
            var result = new List<int>();
            ranked = ranked.Distinct().ToList();
            var index = 0;
            int i;
            for (i = ranked.Count - 1; i >= 0; i--)
            {
                if (index == player.Count)
                {
                    break;
                }

                var current = ranked[i];
                if (current > player[index])
                {
                    result.Add(i+2);
                    index++;
                    i++;
                }
                else if (current == player[index])
                {
                    result.Add(i+1);
                    index++;

                }
            }

            for (int j = index; j < player.Count; j++)
            {
                result.Add(i+2);
            }
            return result;
        }

    }
}
