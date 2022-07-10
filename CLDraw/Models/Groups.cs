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
            for (int i = 0; i < 8; i++)
            {
                GroupsList[i] = new List<Club>();
            }
        }

        /// <summary>
        /// Checks if given group is available for given club
        /// </summary>
        /// <param name="club">Club to be checked with group</param>
        /// <param name="group">Group to be checked</param>
        /// <param name="drawRound">Draw round</param>
        /// <param name="unavailableGroups"> list of groups number which are unavailable</param>
        /// <returns>True if group is available</returns>
        private bool CheckIfGroupIsAvailable(Club club, List<Club> group, int drawRound, List<int> unavailableGroups)
        {
            int indexOfGroup = Array.IndexOf(GroupsList, group);
            if (unavailableGroups.Contains(indexOfGroup)) return false;
            if (group.Count == drawRound) return false;
            if (group.Any(clubInGroup => clubInGroup.Country == club.Country)) return false;
            
            return true;
        }

        /// <summary>
        /// Generates pool of groups available to draw for club according to draw round
        /// </summary>
        /// <param name="drawRound">current draw round</param>
        /// <param name="club">club for which pool is generated</param>
        /// <param name="pot">club's pot</param>
        /// <returns>Pool of possible groups to draw</returns>
        public List<int> GeneratePoolForGroupDraw(int drawRound, Club club, List<Club> pot)
        {
            List<int> drawPool = new List<int>();
            List<int> unavailableGroups = CheckForCountriesInGroups(club.Country);

            //Checks which groups have place for club
            for(int i = 0; i < 8; i++)
            {
                if (!CheckIfGroupIsAvailable(club, GroupsList[i], drawRound, unavailableGroups)) continue;

                drawPool.Add(i);
            }
            return drawPool;
        }

        /// <summary>
        /// Checks which half of groups has more clubs from given country and return groups number from this half
        /// </summary>
        /// <param name="country">country to be checked</param>
        /// <returns>List with Groups number with more club from country or empty list if number is equal</returns>
        private List<int> CheckForCountriesInGroups(Country country)
        {
            int clubsInFirstHalf = 0;
            for(int i =0; i < 4; i++)
            {
                var group = GroupsList[i];
                clubsInFirstHalf += group.Count(club => club.Country == country);
            }

            int clubsInSecondHalf = 0;
            for (int i = 4; i < 8; i++)
            {
                var group = GroupsList[i];
                clubsInSecondHalf += group.Count(club => club.Country == country);
            }

            if (clubsInFirstHalf == clubsInSecondHalf) return new List<int>();
            else if (clubsInFirstHalf > clubsInSecondHalf) return new List<int>() { 0, 1, 2, 3 };
            else return new List<int>() { 4, 5, 6, 7 };
        }

    }
}
