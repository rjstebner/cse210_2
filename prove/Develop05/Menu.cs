class Menu
{
    public Menu()
    {
    }
    public string GetMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options");
        Console.WriteLine("1: Create New Goal");
        Console.WriteLine("2: List Goals");
        Console.WriteLine("3: Save Goals");
        Console.WriteLine("4: Load Goals");
        Console.WriteLine("5: Record Event");
        Console.WriteLine("6: Quit");
        Console.Write("Please select your option: ");
        string choice = Console.ReadLine();
        return choice;
    }

}