using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r = new Reference("John", 3, 16);
        string text = "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life.";

        Scripture s = new Scripture(r, text);
//check gettext
        string input = ".";
        while (input != "quit" && !s.AllHidden())
        {
            Console.Clear
            Console.WriteLine(s.GetText());
            Console.WriteLine("Press enter or type quit to end");
            input = Console.ReadLine();
            if (input == "") {
                s.HideWords(3);
            }

        }
        Console.Clear();
        Console.WriteLine(s.GetText());
        Console.WriteLine("Done!");
    }
}