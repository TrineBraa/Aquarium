using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Species : Fish
    {
        public Species(string aName, string aDescription) : base (aName, aDescription) { }

        public List<Species> fishList { get; private set; }
        
        public enum FishSpecies
        {
            Clownfish,
            Pufferfish,
            RoyalGramma,
            BangaiCardinal,
            ChalkBass,
            CorisWrasse,
            Angelfish,
            Damselfish,
            WatchmanGoby,
            YellowTang,
            FirefishGoby,
            Guppy,
            Swordtail,
            NeonTetra,
            GoldFish,
            RainbowShark,
            ZebraFish,

        }

        public List<Species> AllFish()
        {
            fishList = new List<Species>()
            {
                new Species("Clownfish", "What a clown, give him a red nose!"),
                new Species("Pufferfish", "He's a bit scared, don't eat him!"),
                new Species("Royal Gramma", "We have some royalty in here"),
                new Species("Bangai Cardinal", "Such a pretty little priest"), 
                new Species("Chalk Bass", "He is starting a band"),
                new Species("Coris Wrasse", "He's a bit of a weird copycat"),
                new Species("Angel Fish", "A little angel, can do nothing wrong"),
                new Species("Damsel Fish", "Will anyone save her?"),
                new Species("Watchman Goby", "Do you feel watched?"),
                new Species("Yellow Tang", "So bright, so tangy"),
                new Species("Firefish Goby", "Where the heck is the fire?"),
                new Species("Guppy", "Kinda just guppying around"),
                new Species("Swordtail", "Engarde, don't bring a knife to a swordfight"),
                new Species("Neon Tetra", "Neon lightshow, dancing around"),
                new Species("Golf Fish", "A golden child, he'll throw a tantrum!"),
                new Species("Rainbow Shark", "Into his mouth and then all across the rainbow bridge"),
                new Species("Zebra Fish", "Zebra in water? am I losing my mind?"),
            };
            return fishList;
        }

        public void PrintAvailableFish() //Printing all the available fish
        {
            foreach (var _species in fishList)
            {
                Console.WriteLine(_species.Name);
                Console.WriteLine(_species.Description);
            }
        }


         public void GetRandomFish() //Method for getting a random fish from the available fish list
         {
            
         }



    }
};

