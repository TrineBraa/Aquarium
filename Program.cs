/*Lag en C# konsollapplikasjon som imiterer et akvarium, med masse instanser av fisker.
 Hver "art" av fisk skal arve fra en felles klasse Fisk. Interface, Arv og Enum. INNKAPSLING*/


Welcome();


 void Welcome()
 {
    while (true)
    {
        Aquarium.Aquarium aqauarium = new Aquarium.Aquarium();
        Console.Title = "Aquarium Builder";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n \t Welcome to your aquarium!");
        Console.WriteLine("\nThe aquarium is currently empty, maybe you should add some fish to it?");
        Console.WriteLine("You have alot of options for fish you can have in the aquarium" +
                          "\nwe will list some different fish so you can add them into the aquarium, or not whatever you'd prefer.");
        Console.WriteLine("\n\tAre you ready? (Y/N)");
        var StartupResponse = Console.ReadLine().ToLower();

        if (StartupResponse == "y")
        {
            aqauarium.YourAquarium();
            break;
        }
        else if (StartupResponse == "n")
        {
            Console.WriteLine("shutting down");
            Environment.Exit(404);
        }
        else
        {
            Console.WriteLine("Please input either Y for Yes or N for no.");
        }


    }
}   
