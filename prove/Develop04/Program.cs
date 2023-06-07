using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("-- Welcome to the Mental Wellness Program --");
            Console.WriteLine();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1: Breathing Activity");
            Console.WriteLine("2: Listing Activity");
            Console.WriteLine("3: Reflecting Activity");
            Console.WriteLine("4: Quit");
            Console.Write("Please select your option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                BreathingActivity activity = new BreathingActivity();
                Console.WriteLine(activity.GetName());
                Console.WriteLine("");
                Console.WriteLine(activity.GetDescription());
                Console.WriteLine("");

                Console.Write("In seconds, about how long would you like your session to last? ");
                int duration;
                if (int.TryParse(Console.ReadLine(), out duration))
                {
                    Console.Clear();
                    activity.GetReady();
                    activity.StartBreathingActivity(duration);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid duration in seconds.");
                }
            }
            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("Listing");
            }
            else if (choice == "3")
            {
                Console.Clear();
                Console.WriteLine("Reflecting");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you");
            }
        }
    }
}
