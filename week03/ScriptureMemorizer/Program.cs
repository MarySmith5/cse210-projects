using System;
//  I enriched the program by loading a list of scriptures from a .txt file, 
// so the game would have more than one scripture to memorize.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        ScriptureRepository scriptureRepository = new ScriptureRepository();
        foreach (Scripture scripture in scriptureRepository.GetScriptures())
        {
            scripture.DisplayScripture();
            string response = "";
            while (response != "quit" && !scripture.IsWordListAllHidden())
            {
                Console.Write("Click 'enter' to continue or enter 'quit': ");
                response = Console.ReadLine().ToLower();
                scripture.UpdateWordList();
                scripture.DisplayScripture();

            }
            if (response == "quit")
            {
                break;
            }
        }
        Console.WriteLine("All done! Goodbye.");

    }
}