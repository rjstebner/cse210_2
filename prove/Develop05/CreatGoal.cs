public class CreateGoal
{
    public string CreateGoalMenu()
    {
        Console.Clear();
        Console.WriteLine("The Types of Goals are:");
        Console.WriteLine("1: Simple Goal");
        Console.WriteLine("2: Eternal Goal");
        Console.WriteLine("3: Checklist Goal");
        Console.Write("What goal would you like to create? ");
        string choice = Console.ReadLine();
        return choice;
    }
    
    public string GetGoalType()
    {
        string goalType = CreateGoalMenu();
        return goalType;
    }

    public string GetGoalName()
    {
        Console.WriteLine("What is the Name of your Goal? ");
        string goalName = Console.ReadLine();
        return goalName;
    }

    public string GetGoalDescription()
    {
        Console.WriteLine("Please write a breif description of your goal?");
        string goalDescription = Console.ReadLine();
        return goalDescription;
    }

   public int GetGoalScore()
    {
        Console.WriteLine("How many points is this goal worth?");
        string input = Console.ReadLine();
        int goalScore;
        if (int.TryParse(input, out goalScore))
        {
            return goalScore;
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting goal score to 0.");
            return 0;
        }
    }
}
