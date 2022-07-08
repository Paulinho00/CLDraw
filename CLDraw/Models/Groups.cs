using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLDraw.Models
{
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

    }
}
