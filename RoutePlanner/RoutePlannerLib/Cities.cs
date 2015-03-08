using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fhnw.Ecnf.RoutePlanner.RoutePlannerLib
{
    public class Cities
    {
        List<City> CityList = new List<City>();
        public int Count = 0;

        public Cities(){}

        City FindCity(string cityName)
        {
            City res;

            return res;
        }

        public List<City> FindNeighbours(WayPoint _location, double _distance)
        {
            if (this.Count == 0) { return null; }
            else
            {
                List<City> neighbours = new List<City>();
                //List<double> distances = new List<double>();
                foreach (City c in CityList)
                {
                    double dist = c.Location.Distance(_location);
                    if (dist <= _distance)
                    {
                        neighbours.Add(c);
                        //distances.Add(dist);
                    }
                }
                
                return neighbours;
            }
        }

        public int ReadCities(string _filename)
        {
            int countCities = 0;
            TextReader tr = new StreamReader(_filename);

            //string line = tr.ReadLine();
            string line;
            while ((line = tr.ReadLine()) != null)
            {
                string[] city = line.Split('\t');
                City cityOut = new City(city[0].Trim(), city[1].Trim(), Convert.ToInt32(city[2].Trim()),
                    Convert.ToDouble(city[3].Trim()), Convert.ToDouble(city[4].Trim()));
                CityList.Add(cityOut);
                countCities++;
            }
            this.Count += countCities;
            return countCities;
        }

        public City this[int index]
        {   
            get
            {
                if (index > this.Count - 1) { return null; }
                else
                {
                    return CityList[index];
                }
            }
        }
    }
}
