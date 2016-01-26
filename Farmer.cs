using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowCalculator
{
    class Farmer
    {

        public int BagsOfFeed;
        public const int FeedMultiplier = 30;

        private int numberOFCows;
        public int NumberOfCows
        {
            get
            {
                return numberOFCows;
            }
            set
            {
                numberOFCows = value;
                BagsOfFeed = numberOFCows * FeedMultiplier;
            }
        }
    }
}
