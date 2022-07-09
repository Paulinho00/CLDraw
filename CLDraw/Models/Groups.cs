using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLDraw.Models
{
    /// <summary>
    /// Model for groups
    /// </summary>
    public class Groups
    {
        public List<Club>[] GroupsList { get; }

        public Groups()
        {
            GroupsList = new List<Club>[8];
            for(int i = 0; i < 8; i++)
            {
                GroupsList[i] = new List<Club>();
            }
        }

        /// <summary>
        /// Generates pool of groups available to draw according to draw round
        /// </summary>
        /// <param name="drawRound"></param>
        /// <returns></returns>
        public List<int> GeneratePoolForGroupDraw(int drawRound, Club club)
        {
            List<int> drawPool = new List<int>();
            //Checks which groups have place for club
            for(int i = 0; i < 8; i++)
            {
                if (GroupsList[i].Count == drawRound) continue;
                if (GroupsList[i].Any(clubInGroup => clubInGroup.Country == club.Country)) continue;
                drawPool.Add(i);
            }
            return drawPool;
        }

    }
}
