class Menu
{
    public Menu()
    {
    }
    public string GetMenu()
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
        string choice = Console.ReadLine();
        return choice;
    }

}