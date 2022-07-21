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

        public Groups(List<Club>[] groupsList)
        {
            GroupsList = groupsList;
        }

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
        /// <returns>True if group is available</returns>
        private bool CheckIfGroupIsAvailable(Club club, List<Club> group, int drawRound)
        {
            int indexOfGroup = Array.IndexOf(GroupsList, group);
            List<int> unavailableGroups = CheckForCountriesInGroups(club.Country);
            if (unavailableGroups.Contains(indexOfGroup)) return false;
            if (group.Count == drawRound) return false;
            if (group.Any(clubInGroup => clubInGroup.Country == club.Country)) return false;
            
            return true;
        }

        /// <summary>
        /// Checks if given group is available in given groups for given club
        /// </summary>
        /// <param name="club">Club to be checked with group</param>
        /// <param name="group">Group to be checked</param>
        /// <param name="drawRound">Draw round</param>
        /// <param name="groups">groups to be checked</param>
        /// <returns>True if group is available</returns>
        private bool CheckIfGroupIsAvailable(Club club, List<Club> group, int drawRound, List<Club>[] groups)
        {
            int indexOfGroup = Array.IndexOf(groups, group);
            List<int> unavailableGroups = CheckForCountriesInGroups(club.Country, groups);
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

            //Checks which groups have place for club
            for(int i = 0; i < 8; i++)
            {
                if (!CheckIfGroupIsAvailable(club, GroupsList[i], drawRound)) continue;

                drawPool.Add(i);
            }
            List<int> blockingGroups = TestForBlockingWays(drawRound, club, pot, drawPool);

            drawPool.RemoveAll(x => blockingGroups.Contains(x));

            return drawPool;
        }

        /// <summary>
        /// Checks which half of groups have more clubs from given country and return groups number from this half
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

        /// <summary>
        /// Checks which half of given groups have more clubs from given country and return group numbers from this half
        /// </summary>
        /// <param name="country">country to be checked</param>
        /// <returns>List with Groups number with more club from country or empty list if number is equal</returns>
        private List<int> CheckForCountriesInGroups(Country country, List<Club>[] groups)
        {
            int clubsInFirstHalf = 0;
            for (int i = 0; i < 4; i++)
            {
                var group = groups[i];
                clubsInFirstHalf += group.Count(club => club.Country == country);
            }

            int clubsInSecondHalf = 0;
            for (int i = 4; i < 8; i++)
            {
                var group = groups[i];
                clubsInSecondHalf += group.Count(club => club.Country == country);
            }

            if (clubsInFirstHalf == clubsInSecondHalf) return new List<int>();
            else if (clubsInFirstHalf > clubsInSecondHalf) return new List<int>() { 0, 1, 2, 3 };
            else return new List<int>() { 4, 5, 6, 7 };
        }

        /// <summary>
        /// Checks which groups for given club will result in draw block
        /// </summary>
        /// <param name="drawRound">current draw round</param>
        /// <param name="club">club for group checking</param>
        /// <param name="pot">pot in club's draw time</param>
        /// <param name="drawPool">generated numbers of available groups for club</param>
        /// <returns>list of groups which will result in draw block when club is placed in it</returns>
        private List<int> TestForBlockingWays(int drawRound, Club club, List<Club> pot, List<int> drawPool)
        {
            List<int> excludedGroups = new List<int>();
            
            //Checking all possible groups for club for possible draw block
            foreach(int group in drawPool)
            {
                //Creating copies of groups and pot to not broke current pot and groups state
                List<Club>[] testGroups = Array.ConvertAll(GroupsList, x => new List<Club>(x));
                List<Club> clonePot = new List<Club>(pot);

                testGroups[group].Add(club);
                clonePot.Remove(club);
                if (!TestClub(drawRound, clonePot, testGroups)) excludedGroups.Add(group);
            }
            return excludedGroups;

        }

        /// <summary>
        /// Checks if with given pot state and group state will occur draw block
        /// </summary>
        /// <param name="drawRound">current draw round</param>
        /// <param name="pot">state of pot for check</param>
        /// <param name="groups">state of group for check</param>
        /// <returns>True if group block will not happen, false if draw block will certainly happen</returns>
        private bool TestClub(int drawRound, List<Club> pot, List<Club>[] groups)
        {   
            //When method is called and pot is empty, means that all teams are drawn without blocking draw
            if (pot.Count == 0) return true;
            else
            {
                //Check each club in pot for each possible group for possible block
                foreach (Club testClub in pot)
                {
                    for (int i = 0; i < 8; i++)
                    {

                        if (CheckIfGroupIsAvailable(testClub, groups[i], drawRound, groups))
                        {
                            //Cloning group and pot setups to preserve current state for next check of club placement in next group
                            List<Club>[] testGroups = Array.ConvertAll(groups, x => new List<Club>(x));
                            var potClone = new List<Club>(pot);

                            //Call for block check for current combination of groups and pot (next club from pot will be draw for block check)
                            testGroups[i].Add(testClub);
                            potClone.Remove(testClub);

                            //If setup of clubs in groups without draw block is detected then combination will not block draw so return truee
                            if (TestClub(drawRound, potClone, testGroups)) return true;
                        }
                    }
                }
                return false;
            }
        }

    }
}
