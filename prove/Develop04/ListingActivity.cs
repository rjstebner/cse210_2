using System;
using System.Threading;

class ListingActivity : Activity
{
    static string listingDescription = "This activity will help you reflect on the good things in your life by having you type a list as many things as you can in a certain area.";
    public ListingActivity() : base("Listing Activity", listingDescription, 20)
    {
    }
public void StartListingActivity(int duration)
{
    Animation animation = new Animation();
    Prompt prompt = new Prompt();
    Console.Clear();
    Console.WriteLine("List as many resonpses as you would like to the following prompt");
    Console.WriteLine("");
    Console.WriteLine(prompt.GetRandomListingPrompt());
    animation.Countdown();
    Console.WriteLine("");

    DateTime endTime = DateTime.Now.AddSeconds(duration);
    List<string> lines = new List<string>();

    while (DateTime.Now < endTime)
    {
        Console.Write("> ");
        string line = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(line))
        {
            lines.Add(line);
        }
    }

    Console.WriteLine($"You have finished roughly {duration} of the Listing Activity. You wrote the following lines:");
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }

    Console.WriteLine("Press Enter to continue.");
    Console.ReadLine();
}
}
