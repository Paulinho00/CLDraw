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
            Pot1 = new List<Club>();
            Pot2 = new List<Club>();
            Pot3 = new List<Club>();
            Pot4 = new List<Club>();
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
    }
}
