using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a sample Reference object
        Reference reference = new Reference("John", 3, 16);

        // Create a sample Scripture object
        string text = "This is a sample scripture text with words to be hidden.";
        Scripture scripture = new Scripture(reference, text);
        Console.Clear();
        Console.WriteLine(text);

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
                Console.Write(scripture.GetRenderedDisplay());
                Console.WriteLine();
                
            }
        }
    }
}