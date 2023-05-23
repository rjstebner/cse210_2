using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a sample Reference object
        Reference reference = new Reference("John", 3, 16);

        // Create a sample Scripture object
        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Scripture scripture = new Scripture(reference, text);
        Console.Clear();
        Console.WriteLine($"{reference.GetReference()}: {text}");

        string input = "";
        while (input.ToLower() != "quit")
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to show the scripture with a hidden word, or type 'quit' to exit.");
            input = Console.ReadLine();

            if (input == "quit")
            {
                Console.WriteLine("Thank You");
            }
            else
            {
                Console.Clear();
                Console.Write($"{reference.GetReference()}: ");
                scripture.HideWords();
                Console.WriteLine(scripture.GetRenderedDisplay());
                Console.WriteLine();
            }
        }
    }
}
