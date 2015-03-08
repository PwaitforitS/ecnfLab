using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Fhnw.Ecnf.RoutePlanner.RoutePlannerLib;

namespace Fhnw.Ecnf.RoutePlanner.RoutePlannerConsole
{
    class RoutePlannerConsoleApp
    {
        static void Main(string[] args)
        {
            // Lab1, 1c) Welcome
            Console.WriteLine("Welcome to RoutePlanner (Version {0})\n", Assembly.GetExecutingAssembly().GetName().Version);

            // Lab1, 2d) WayPoint Test
            var wayPoint = new WayPoint("Windisch", 47.479319847061966, 8.212966918945312);
            Console.WriteLine("{0}: {1}/{2}", wayPoint.Name, wayPoint.Latitude, wayPoint.Longitude);

            // Lab2, 1a) WayPoint Format
            Console.WriteLine(wayPoint.ToString());

            // Lab2, 1b) Distance Test
            var wpBern = new WayPoint("Bern", 46.945530, 7.423194);
            var wpTripolis = new WayPoint("Tripolis", 32.845907, 13.221563);
            Console.WriteLine("Distanz zwischen Bern-CH und Tripolis-LY: {0} km", string.Format("{0:0,0.00}",wpBern.Distance(wpTripolis)));

            // Quit
            Console.WriteLine("\nPress any key to quit");
            Console.ReadKey();
        }

    }
}
