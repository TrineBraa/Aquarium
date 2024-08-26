using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Aquarium.Species;

/*Holder alle fiskene*/
namespace Aquarium
{
    internal class Aquarium
    {
        Species Species;
        List<FishSpecies> inTank = new List<FishSpecies>();
        public Aquarium tank;

        public void YourAquarium() //This will print your current tank
        {
            Console.WriteLine("here is your tank!");
            Console.WriteLine();
            FishInTank();

        }



        public void AquariumMenu() //Different options for options to do and to exit the app
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
    }
}
