using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Location_Generator
{
    public static class RandomNumberGenerator
    {
        private static Random _generator = new Random();

        public static int NumberBetween()
        {
            return _generator.Next(Place.Locations.Count) +1;
        }
    }
}
