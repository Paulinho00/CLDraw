using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLDraw.Models
{
    /// <summary>
    /// Contains four pots for draw
    /// </summary>
    public class Pots
    {


        public List<Club>[] PotsList { get; }
        public Pots()
        {
            PotsList = new List<Club>[4];
            PotsList[0] = new List<Club>
            {
                new Club("Chelsea FC", Country.England),
                new Club("Villareal", Country.Spain),
                new Club("Atletico Madrid", Country.Spain),
                new Club("Manchester City", Country.England),
                new Club("Bayern Munich", Country.Germany),
                new Club("Inter", Country.Italy),
                new Club("Lille", Country.France),
                new Club("Sporting", Country.Portugal)

            };
            PotsList[1] = new List<Club>()
            {
                new Club("Real Madrid", Country.Spain),
                new Club("Barcelona", Country.Spain),
                new Club("Juventus", Country.Italy),
                new Club("Manchester United", Country.England),
                new Club("Paris Sain-Germain", Country.France),
                new Club("Liverpool", Country.England),
                new Club("Sevilla", Country.Spain),
                new Club("Borussia Dortmund", Country.Germany)
            };
            PotsList[2] = new List<Club>()
            {
                new Club("Porto", Country.Portugal),
                new Club("Ajax", Country.Netherlands),
                new Club("Shakhar Donetsk", Country.Ukraine),
                new Club("RB Leipzig", Country.Germany),
                new Club("Red Bull Salzburg", Country.Austria),
                new Club("Benfica", Country.Portugal),
                new Club("Atalanta", Country.Italy),
                new Club("AEK Athens", Country.Greece)
            };
            PotsList[3] = new List<Club>()
            {
                new Club("Besiktas", Country.Turkey),
                new Club("Dynamo Kyiv", Country.Ukraine),
                new Club("Club Brugge", Country.Belgium),
                new Club("Young Boys", Country.Switzerland),
                new Club("AC Milan", Country.Italy),
                new Club("Malmo", Country.Sweden),
                new Club("Wolfsburg", Country.Germany),
                new Club("AS Monaco", Country.France)
            };
        }

        /// <summary>
        /// Adds club to chosen pot
        /// </summary>
        /// <param name="potNumber">pot which club will be placed in</param>
        /// <param name="newClub">new club to be placed in pot</param>
        /// <exception cref="ArgumentException">throws when pot is full</exception>
        public void AddClub(int potNumber, Club newClub)
        {
            if (PotsList[potNumber].Count < 8) PotsList[potNumber].Add(newClub);
            else throw new ArgumentException();
        }

        /// <summary>
        /// Checks if there is enough teams in pots to start draw
        /// </summary>
        /// <returns>True if in every pot is 8 teams</returns>
        public bool CheckPotsReadyForDraw()
        {
            foreach(List<Club> pot in PotsList)
            {
                if (pot.Count < 8) return false;
            }
            return true;
        }
    }
}
