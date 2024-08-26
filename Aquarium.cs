﻿using System;
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
        
        List<Species> inTank = new List<Species>();
        Species species = new Species("temp", "temp Description");

        public void YourAquarium() //This will print your current tank
        {
            //var species = new Species("temp", "temp Description");
            //var AllFish = species.GetAllFish();

            while (true)
            {
                Console.WriteLine("here is your tank!");
                Console.WriteLine();
                if (inTank.Count > 0)
                {
                    FishInTank();
                }
                else if (inTank.Count == 0)
                {
                    Console.WriteLine("You currently have no fish in your tank, Add some!");
                }
                AquariumMenu();
            }
        }


        public void AquariumMenu() //Different options for options to do and to exit the app
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("You have some different options:");
            Console.WriteLine("\t1: Add a fish of your choosing");
            Console.WriteLine("\t2: Get a random fish");
            Console.WriteLine("\t3: Restart the fish choosing");
            Console.WriteLine("\t4: Exit the app");
            var Respone = Console.ReadLine();
            switch (Respone)
            {
                case "1":
                    PutFishInTank();
                    break;
                case "2":
                    RandomFishInTank();
                    break;
                case "3":
                    EmptyTank();
                    break;
                case "4":
                    Environment.Exit(404);
                    break;
                default:
                    Console.WriteLine("Please input a valid option");
                    break;
            }
        }

        public void PutFishInTank() //The Chosen fish get's put in the tank list
        {
            Console.WriteLine("You can choose what fish you want to add to your tank here, just write the name of the fish you'd like to add!");
            Console.WriteLine("\n\t here are your options for fish!");
            Console.WriteLine("\n");
            species.PrintAvailableFish(species.GetAllFish());
            Console.WriteLine();
            Console.WriteLine("Write the name of the fish you want to add, exit to return to previous menu.");
            var AddFish= Console.ReadLine().ToLower();
        }

        public void RandomFishInTank() //You get a given random fish that you can choose to add to your tank or not.
        {
            Console.Clear();
            Console.WriteLine("Here a Random fish will appear! you want to add it to your tank or let it go?");
            Console.WriteLine();
            Console.WriteLine("Add it to tank? (Y/N), exit to return to previous menu.");
            var RandomFish = Console.ReadLine().ToLower();
        }

        public void EmptyTank() //Method to empty the tank and start again
        {
            Console.Clear();
            Console.WriteLine("Do you want to empty your tank and start with an empty one? (Y/N), exit to return to previous menu.");
            var EmptyTank = Console.ReadLine().ToLower();
        }


        public void FishInTank(List<Species> inTank) //To show the fish in the tank
        {
            foreach (var fishSpecies in inTank)
            {
                Console.WriteLine(fishSpecies.Name);
                Console.WriteLine(fishSpecies.Description);
            }
        }

      
         
        
    }
}
