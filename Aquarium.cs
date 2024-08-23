using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Holder alle fiskene*/
namespace Aquarium
{
    internal class Aquarium
    {
        Species Species;
       
        public Aquarium tank;

        public void YourAquarium() //This will print your current tank
        {
            Console.WriteLine("here is your tank!");
            Console.WriteLine();
            Species.FishInTank();

        }

        public void AquariumMenu() //Different options for options to do and to exit the app
        {

        }

       

    }
}
