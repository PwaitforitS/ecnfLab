using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fhnw.Ecnf.RoutePlanner.RoutePlannerLib
{
    public class WayPoint
    {
        public string Name { get; private set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        
        public WayPoint(string _name, double _latitude, double _longitude)
        {
            this.Name = _name;
            this.Latitude = _latitude;
            this.Longitude = _longitude;
        }

        public override string ToString()
        {
            if (this.Name == null)
            {
                //return string.Format("WayPoint: {0}/{1}", string.Format("{0:0,0.00}", this.Latitude),
                    //string.Format("{0:0,0.00}", this.Longitude));
                return string.Format("WayPoint: {0:N2}/{1:N2}", this.Latitude, this.Longitude);
            }
            else
            {
                //return string.Format("WayPoint: {0} {1}/{2}", this.Name, string.Format("{0:0,0.00}", this.Latitude),
                    //string.Format("{0:0,0.00}", this.Longitude));
                return string.Format("WayPoint: {0} {1:N2}/{2:N2}", this.Name, this.Latitude, this.Longitude);
            }
        }

        /*
        public override string ToString()
        {   String strOut = "WayPoint: ";
            if (Name != null)
            {
                strOut += this.Name;
                strOut += " ";
            }
            strOut += this.Latitude;
            strOut += "/";
            strOut += this.Longitude;


            return strOut;
            //return base.ToString();
        }
        */

        public double Distance(WayPoint target)
        {
            double radius = 6371;
            double dist = 0;
            
            double phiA = this.Latitude/360 * 2*Math.PI;
            double LamA = this.Longitude/360 * 2*Math.PI;
            double phiB = target.Latitude/360 * 2*Math.PI;
            double LamB = target.Longitude/360 * 2*Math.PI;
            
            /*
            double phiA = this.Longitude;
            double LamA = this.Latitude;
            double phiB = target.Longitude;
            double LamB = target.Latitude;
            */
            dist = radius * acos( sin(phiA)*sin(phiB) + cos(phiA)*cos(phiB)*cos(LamA-LamB) );

            Console.WriteLine("DistanceTEST: {0}", cos(Math.PI/4));

            return dist;
        }

        private double sin(double phi)
        {
            return Math.Sin(phi);
        }

        private double cos(double phi)
        {
            return Math.Cos(phi);
        }

        private double acos(double phi){
            return Math.Acos(phi);
        }
    }
}
