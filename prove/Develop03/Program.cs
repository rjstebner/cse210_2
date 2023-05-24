using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureProvider scriptureProvider = new ScriptureProvider();
        (Reference reference, string text) = scriptureProvider.GetRandomScripture();

        if (reference != null && !string.IsNullOrEmpty(text))
        {
            Scripture scripture = new Scripture(reference, text);
            Console.Clear();
            Console.WriteLine($"{reference.GetReferenceString()}: {text}");

            string input = "";
            while (input.ToLower() != "quit")
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to show the scripture with hidden words, or type 'quit' to exit.");
                input = Console.ReadLine();

                if (input == "quit")
                {
                    Console.WriteLine("Thank you.");
                }
                else
                {
                    Console.Clear();
                    scripture.HideWords();
                    Console.Write($"{reference.GetReferenceString()}: ");
                    Console.WriteLine(scripture.GetRenderedDisplay());
                    Console.WriteLine();
                }
            }
        }
        else
        {
            Console.WriteLine("No scriptures available.");
        }
    }
}
