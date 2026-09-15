using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        ScriptureRepository scriptureRepository = new ScriptureRepository();
        int countScriptures = 0;
        while (countScriptures < scriptureRepository.GetScriptures().Count)
        {
            Scripture scripture = scriptureRepository.GetNextScripture();
            Console.Write("Click 'enter' to continue or enter 'quit': ");
            string response = Console.ReadLine().ToLower();
            while (response != "quit" && !scripture.IsWordListAllHidden())
            {
                scripture.DisplayScripture();
                scripture.UpdateScriptureText();
                Console.Write("Click 'enter' to continue or enter 'quit': ");
                response = Console.ReadLine().ToLower();
            }
            if (response == "quit")
            {
                Console.WriteLine("See you later!");
                break;
            }
            countScriptures += countScriptures;
        }
        Console.WriteLine("Congratulations! You have mastered all the Book of Mormon seminary verses!");
    }
}