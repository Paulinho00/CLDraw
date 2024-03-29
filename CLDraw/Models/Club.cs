﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLDraw.Models
{
    public class Club
    {
        public string Name { get; }
        public Country Country { get; }

        public Club(string name, Country country)
        {
            this.Name = name;
            this.Country = country;
        }
    }

    public enum Country
    {
        Austria,
        Belgium,
        Croatia,
        Cyprus,
        Czechia,
        Denmark,
        England,
        Finland,
        France,
        Germany,
        Greece,
        Netherlands,
        Hungary,
        Italy,
        Norway,
        Poland,
        Portugal,
        Ireland,
        Romania,
        Scotland,
        Spain,
        Sweden,
        Switzerland,
        Turkey,
        Ukraine
    }
}
