using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fhnw.Ecnf.RoutePlanner.RoutePlannerLib
{
    public class City
    {
        public string Name;
        public string Country;
        public int Population;
        public WayPoint Location;

        public City(string _name, string _country, int _population, double _latitude, double _longitude)
        {
            this.Name = _name;
            this.Country = _country;
            this.Population = _population;
            this.Location = new WayPoint(_name, _latitude, _longitude);
        }
    }
}
