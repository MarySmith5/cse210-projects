using System;
//  I enriched the program by loading a list of scriptures from a .txt file, 
// so the game would have more than one scripture to memorize.
// Give the player the opportunity to memorize another scripture after they complete one.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        ScriptureRepository scriptureRepository = new ScriptureRepository();
        Console.Write("Shall I choose a scripture for you to memorize? y/n: ");
        string getScripture = Console.ReadLine().ToLower();
        if (getScripture != "y")
        {
            Console.WriteLine("Goodbye");
        }
        else
        {
            while (getScripture == "y")
            {
                Scripture scripture = scriptureRepository.GetAScripture();
                scripture.DisplayScripture();
                string response = "";
                while (response != "quit" && !scripture.IsWordListAllHidden())
                {
                    Console.Write("Click 'enter' to continue or enter 'quit': ");
                    response = Console.ReadLine().ToLower();
                    scripture.UpdateWordList();
                    scripture.DisplayScripture();

                }
                if (scripture.IsWordListAllHidden())
                {
                    Console.WriteLine("Congratulations! You finished the scripture!");
                    Console.Write("Shall I choose another scripture for you to memorize? y/n: ");
                    getScripture = Console.ReadLine().ToLower();
                }
                if (response == "quit")
                {
                    break;
                }
            }
        }
        Console.WriteLine("All done! Goodbye.");

    }
}