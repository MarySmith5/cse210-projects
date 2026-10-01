using System;
using System.Net;

// for enrichment I give the option to see the menu again after one mindfulness activity is complete.
// I also added a "hold" instruction so that the breathing activity would guide through traditional "box breathing"

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine();
        Menu menu = new Menu();
        string decision = "y";
        while (decision == "y")
        {
            menu.GetMenu();
            int choice = menu.GetChoice();
            menu.OrchestrateMenuChoice(choice);
            if (choice != 4)
            {
                Console.Write("Would you like to do another mindfulness activity? y or n: ");
                decision = Console.ReadLine().ToLower();
            }
            else
            {
                decision = "n";
            }
        }
        Console.WriteLine("Goodbye");
    }
}