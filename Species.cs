using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Species : Fish
    {
        public List<Species> FishList { get; private set; }
        public Species(string aName, string aDescription) : base ( aName, aDescription)
        {
            FishList = new List<Species>();

        }
        
       
        
        
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

        public List<Species> GetAllFish()
        {
                FishList.Add(new Species("Clownfish", "What a clown, give him a red nose!"));
                FishList.Add(new Species("Pufferfish", "He's a bit scared, don't eat him!"));
                FishList.Add(new Species("Royal Gramma", "We have some royalty in here"));
                FishList.Add(new Species("Bangai Cardinal", "Such a pretty little priest"));
                FishList.Add(new Species("Chalk Bass", "He is starting a band"));
                FishList.Add(new Species("Coris Wrasse", "He's a bit of a weird copycat"));
                FishList.Add(new Species("Angel Fish", "A little angel, can do nothing wrong"));
                FishList.Add(new Species("Damsel Fish", "Will anyone save her?"));
                FishList.Add(new Species("Watchman Goby", "Do you feel watched?"));
                FishList.Add(new Species("Yellow Tang", "So bright, so tangy"));
                FishList.Add(new Species("Firefish Goby", "Where the heck is the fire?"));
                FishList.Add(new Species("Guppy", "Kinda just guppying around"));
                FishList.Add(new Species("Swordtail", "Engarde, don't bring a knife to a swordfight"));
                FishList.Add(new Species("Neon Tetra", "Neon lightshow, dancing around"));
                FishList.Add(new Species("Gold Fish", "A golden child, he'll throw a tantrum!"));
                FishList.Add(new Species("Rainbow Shark", "Into his mouth and then all across the rainbow bridge"));
                FishList.Add(new Species("Zebra Fish", "Zebra in water? am I losing my mind?"));
            return FishList;
        }

       
        public void PrintAvailableFish(List<Species>fishList) //Printing all the available fish
        {
            Console.Clear();
            foreach (var species in fishList)
            {
                Console.WriteLine("\n"+species.Name);
                Console.WriteLine("\t"+species.Description);
            }

        }


         public Species GetRandomFish() //Method for getting a random fish from the available fish list
         {
             Random random = new Random();
             int randomFish = random.Next(FishList.Count) ;
             return FishList[randomFish];
         }

    }
};

