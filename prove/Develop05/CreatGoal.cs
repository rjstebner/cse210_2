public class CreateGoal
{
    public string CreateGoalMenu()
    {
        Console.WriteLine("The Types of Goals are:");
        Console.WriteLine("1: Simple Goal");
        Console.WriteLine("2: Eternal Goal");
        Console.WriteLine("3: Checklist Goal");
        Console.Write("What goal would you like to create? ");
        string choice = Console.ReadLine();
        return choice;
    }
    
    public string SetGoalType()
    {
        string goalType = CreateGoalMenu();
        return goalType;
    }

    public string SetGoalName()
    {
        Console.WriteLine("What is the Name of your Goal? ");
        string goalName = Console.ReadLine();
        return goalName;
    }

    public string SetGoalDescription()
    {
        Console.WriteLine("Please write a breif description of your goal?");
        string goalDescription = Console.ReadLine();
        return goalDescription;
    }

   public int SetGoalScore()
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
    public int SetNumTimes()
    {
        Console.WriteLine("How many times will you achieve this goal?");
        string input = Console.ReadLine();
        int numTimes;
        if (int.TryParse(input, out numTimes))
        {
            return numTimes;
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting goal score to 0.");
            return 0;
        }
    }
        public int SetBonusPoints()
    {
        Console.WriteLine("How many bonus points will you earn when you have completed you set target of times?");
        string input = Console.ReadLine();
        int bonusPoints;
        if (int.TryParse(input, out bonusPoints))
        {
            return bonusPoints;
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting goal score to 0.");
            return 0;
        }
    }
}
