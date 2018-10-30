using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Location_Generator
{
    public class Place
    {
        public static readonly List<Location> Locations = new List<Location>();

        public const int Location_ID_Snobby_Shores = 1;
        public const int Location_ID_Risky_Reels = 2;
        public const int Location_ID_Fatal_Fields = 3;
        public const int Location_ID_Lucky_Landing = 4;

        static Place()
        {
            PopulateLocations();
        }

        private static void PopulateLocations()
        {
            Location snobbyShores = new Location(Location_ID_Snobby_Shores, "Snobby Shores", "Houses on the West cost");

            Location riskyReels = new Location(Location_ID_Risky_Reels, "Risky Reels", "The new Tilted Towers");

            Location fatalFields = new Location(Location_ID_Fatal_Fields, "Fatal Fields", " Baby Anarchy");

            Location luckyLanding = new Location(Location_ID_Lucky_Landing, "Lucky Landing", "China Town"); 

            Locations.Add(snobbyShores);
            Locations.Add(riskyReels);
            Locations.Add(fatalFields);
            Locations.Add(luckyLanding);
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)

                {
                    return location;
                }
            }

            return null;
        }
    }
}
