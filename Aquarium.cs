using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
            species.GetAllFish();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("here is your tank!");
                Console.WriteLine("\n");
                if (inTank.Count > 0)
                {
                    FishInTank(inTank);
                }
                else if (inTank.Count == 0)
                {
                    Console.WriteLine("\nYou currently have no fish in your tank, Add some!");
                }

                AquariumMenu();
            }
        }


        public void AquariumMenu() //Different options for options to do and to exit the app
        {
            Console.WriteLine("\nWhat do you want to do?");
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
                    Console.Clear();
                    Console.WriteLine("Shutting down app");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please input a valid option");
                    break;
            }
        }

        public void PutFishInTank() //The Chosen fish get's put in the tank list
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You can choose what fish you want to add to your tank here, just write the name of the fish you'd like to add!");
                Console.WriteLine("\n\there are your options for fish!");
                Console.WriteLine("\n");
                species.PrintAvailableFish(species.FishList);
                Console.WriteLine();
                Console.WriteLine("Write the name of the fish you want to add, exit to return to previous menu.");
                var AddFishInput = Console.ReadLine().ToLower();
                if (AddFishInput == "exit")
                {
                    return;
                }
                else
                {
                    var selectedFish = species.FishList.FirstOrDefault(f => f.Name.ToLower() == AddFishInput);
                    if (selectedFish != null)
                    {
                        Console.Clear();
                        inTank.Add(selectedFish);
                        Console.WriteLine($"{selectedFish.Name} was added to your tank");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Fish was not found, please try again!");
                        Thread.Sleep(2000);
                    }
                }
            }
        }

        public void RandomFishInTank() //You get a given random fish that you can choose to add to your tank or not.
        {
            while (true)
            {
                Console.Clear();
                Species randomFish = species.GetRandomFish();
                Console.WriteLine("Here a Random fish will appear! you want to add it to your tank or let it go?");
                Console.WriteLine();
                Console.WriteLine("\n" + randomFish.Name + " appears!");
                Console.WriteLine();
                Console.WriteLine("\nAdd it to tank? (Y/N), exit to return to previous menu.");
                var RandomFish = Console.ReadLine().ToLower();
                if (RandomFish == "y")
                {
                    
                    inTank.Add(randomFish);
                    Console.WriteLine($"\n\tYou added {randomFish.Name} to your tank!");
                    Console.ReadKey();
                    continue;
                }
                else if (RandomFish == "n")
                {
                    
                    Console.WriteLine("\n\tFinding a new fish");
                    Console.ReadKey();
                    continue;
                }
                else if (RandomFish == "exit")
                {
                    
                    Console.WriteLine("\n\tLeaving fish randomizer");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("\n\tplease input either y/n or exit!");
                }
            }
        }

        public void EmptyTank() //Method to empty the tank and start again
        {
            Console.Clear();
            Console.WriteLine("Do you want to empty your tank and start a new? (Y/N)");
            var EmptyTank = Console.ReadLine().ToLower();
            if (EmptyTank == "y")
            {
                inTank.Clear();
                Console.WriteLine("\n\tYou have emptied the tank of fish!");
                Thread.Sleep(2000);
            }
            else
            {
                return;
            }
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
