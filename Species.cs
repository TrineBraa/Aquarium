using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Species : Fish
    {
        List<Species.FishSpecies> fishList = new List<Species.FishSpecies>();
        List<FishSpecies> inTank = new List<FishSpecies>();
        public enum FishSpecies
        {
            Clownfish,
            Pufferfish,
            RoyalGramma,
            BangaiiCardinal,
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


        public void PrintAvailableFish() //Printing all the avalible fish
        {

        }

        public void PutFishInTank() //The Chosen fish get's put in the tank list
        {

        }

        public void FishInTank() //To show the fish in the tank
        {
            foreach (var fishSpecies in inTank)
            {
                
            }
            
        }

        public void GetRandomFish()
        {
            //Method for getting a random fish from the avalible fish list
        }

    }
}
