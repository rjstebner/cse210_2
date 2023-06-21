class Menu
{
    public Menu()
    {
    }
    public string GetMenu()
    {
        Console.WriteLine("Menu Options");
        Console.WriteLine();

        Console.WriteLine("1: Create New Goal");
        Console.WriteLine("2: List Goals");
        Console.WriteLine("3: Save Goals");
        Console.WriteLine("4: Load Goals");
        Console.WriteLine("5: Record Event");
        Console.WriteLine("6: Quit");
        Console.WriteLine();

        Console.Write("Please select your option: ");
        string choice = Console.ReadLine();
        Console.WriteLine();
        
        return choice;
    }

}