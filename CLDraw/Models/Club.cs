using System;
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
        AUSTRIA,
        BELGIUM,
        CROATIA,
        CYPRUS,
        CZECHIA,
        DENMARK,
        ENGLAND,
        FINLAND,
        FRANCE,
        GERMANY,
        GREECE,
        NETHERLANDS,
        HUNGARY,
        ITALY,
        NORWAY,
        POLAND,
        PORTUGAL,
        IRELAND,
        ROMANIA,
        SCOTLAND,
        SPAIN,
        SWEDEN,
        SWITZERLAND,
        TURKEY,
        UKRAINE
    }
}
