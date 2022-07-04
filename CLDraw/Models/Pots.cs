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
    }
}
