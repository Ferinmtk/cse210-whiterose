using System;

class Program
{
    static void Main(string[] args)
    {
        
        ScriptureReference reference = new ScriptureReference("2 Nephi", 2, 25);
        string scriptureText = "Adam fell that men might be;and men are, that they might have joy.";
        ScriptureText scripture = new ScriptureText(reference, scriptureText);

        while (true)
        {
            scripture.Display();
            string input = Console.ReadLine()?.ToLower();

            if (input == "quit")
            {
                break;
            }

            if (!scripture.HideRandomWord())
            {
                Console.WriteLine("All words are hidden. Press Enter to exit.");
                break;
            }

            Console.ReadLine();
        }

        Console.WriteLine("Program ended. Press any key to exit.");
        Console.ReadKey();
    }
}