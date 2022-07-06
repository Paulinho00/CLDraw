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


        public List<Club> Pot1 { get; }
        public List<Club> Pot2 { get; }
        public List<Club> Pot3 { get; }
        public List<Club> Pot4 { get; }
        public Pots()
        {
            Pot1 = new List<Club>
            {
                new Club("1", Country.Austria),
                new Club("2", Country.Belgium),
                new Club("3", Country.Croatia),
                new Club("4", Country.Denmark),
                new Club("5", Country.England),
                new Club("6", Country.Cyprus),
                new Club("7", Country.Hungary),
                new Club("8", Country.Ireland)

            };
            Pot2 = new List<Club>()
            {
                new Club("9", Country.Austria),
                new Club("10", Country.Belgium),
                new Club("11", Country.Croatia),
                new Club("12", Country.Denmark),
                new Club("13", Country.England),
                new Club("14", Country.Cyprus),
                new Club("15", Country.Hungary),
                new Club("16", Country.Ireland)
            };
            Pot3 = new List<Club>()
            {
                new Club("17", Country.Austria),
                new Club("18", Country.Belgium),
                new Club("19", Country.Croatia),
                new Club("20", Country.Denmark),
                new Club("21", Country.England),
                new Club("22", Country.Cyprus),
                new Club("23", Country.Hungary),
                new Club("24", Country.Ireland)
            };
            Pot4 = new List<Club>()
            {
                new Club("25", Country.Austria),
                new Club("26", Country.Belgium),
                new Club("27", Country.Croatia),
                new Club("28", Country.Denmark),
                new Club("29", Country.England),
                new Club("30", Country.Cyprus),
                new Club("31", Country.Hungary),
                new Club("32", Country.Ireland)
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
            switch (potNumber)
            {
                case 1:
                    {
                        if (Pot1.Count < 8) Pot1.Add(newClub);
                        else throw new ArgumentException();
                    } break;
                case 2:
                    {
                        if (Pot2.Count < 8) Pot2.Add(newClub);
                        else throw new ArgumentException();
                    } break;
                case 3:
                    {
                        if (Pot3.Count < 8) Pot3.Add(newClub);
                        else throw new ArgumentException();
                    } break;
                case 4:
                    {
                        if (Pot4.Count < 8) Pot4.Add(newClub);
                        else throw new ArgumentException();
                    } break;
            }
        }

        /// <summary>
        /// Checks if there is enough teams in pots to start draw
        /// </summary>
        /// <returns>True if in every pot is 8 teams</returns>
        public bool CheckPotsReadyForDraw()
        {
            if (Pot1.Count < 8) return false;
            if (Pot2.Count < 8) return false;
            if (Pot3.Count < 8) return false;
            if (Pot4.Count < 8) return false;
            return true;
        }
    }
}
