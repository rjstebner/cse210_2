using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        int pointTotal = 0;
        string choice = "";
        List<Goal> goalList = new List<Goal>();


        while (choice != "6")
        {

            Menu menu = new Menu();

            Console.WriteLine("Welcome to Your Eteranl quest!");
            Console.WriteLine();
            Console.Write("Your current point total is: ");
            Console.WriteLine(pointTotal);
            Console.WriteLine();
            choice = menu.GetMenu();

            if (choice == "1")
            {
                // Create a new goal and add it to the goal list
                CreateGoal create = new CreateGoal();
                string option = create.SetGoalType();

                if (option == "1")
                {
                    string goalName = create.SetGoalName();
                    string goalDescription = create.SetGoalDescription();
                    int goalScore = create.SetGoalScore();
                    SimpleGoal goal = new SimpleGoal(option, goalName, goalDescription, goalScore, false);
                    goalList.Add(goal);
                }
                else if (option == "2")
                {
                    string goalName = create.SetGoalName();
                    string goalDescription = create.SetGoalDescription();
                    int goalScore = create.SetGoalScore();
                    EternalGoal goal = new EternalGoal(option, goalName, goalDescription, goalScore, false);
                    goalList.Add(goal);
                }
                else if (option == "3")
                {
                    string goalName = create.SetGoalName();
                    string goalDescription = create.SetGoalDescription();
                    int goalScore = create.SetGoalScore();
                    int numTimes = create.SetNumTimes();
                    int bonusPoints = create.SetBonusPoints();
                    ChecklistGoal goal = new ChecklistGoal(option, goalName, goalDescription, goalScore, false, numTimes, 0, bonusPoints);
                    goalList.Add(goal);
                }

            }
            else if (choice == "2")
            {
                // Print the list of goals with their scores and completion status
                foreach (Goal goal in goalList)
                {
                    if (goal is ChecklistGoal checklistGoal)
                    {
                        string completionStatus = $"{checklistGoal.NumTimesCompleted}/{checklistGoal.NumTimes}";
                        string checkBox = goal.IsCompleted() ? "[X]" : "[ ]";
                        Console.WriteLine($"{checkBox} {goal.GetGoalType()} | Name: {goal.GetGoalName()} | Description: {goal.GetGoalDescription()} | Score: {goal.GetGoalScore()} | Completed: {completionStatus}");
                    }
                    else
                    {
                        string checkBox = goal.IsCompleted() ? "[X]" : "[ ]";
                        Console.WriteLine($"{checkBox} {goal.GetGoalType()} | Name: {goal.GetGoalName()} | Description: {goal.GetGoalDescription()} | Score: {goal.GetGoalScore()}");
                    }
                }

                Console.WriteLine($"Total Points: {pointTotal}");
            }

            else if (choice == "3")
            {
                // Save the goal list to a text file
                Console.WriteLine("Enter the file name to save:");
                string fileName = Console.ReadLine();

                try
                {
                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        writer.WriteLine(pointTotal);
                        foreach (Goal goal in goalList)
                        {
                            if (goal is ChecklistGoal checklistGoal)
                        {
                            string completionStatus = $"{checklistGoal.NumTimesCompleted}/{checklistGoal.NumTimes}";
                            writer.WriteLine($"{goal.IsCompleted()}|{goal.GetGoalType()}|{goal.GetGoalName()}|{goal.GetGoalDescription()}|{goal.GetGoalScore()}/{completionStatus}/{goal.GetBonusPoints()}");
                        }
                        else
                        {
                            string checkBox = goal.IsCompleted() ? "[X]" : "[ ]";
                            writer.WriteLine($"{goal.IsCompleted()}|{goal.GetGoalType()}|{goal.GetGoalName()}|{goal.GetGoalDescription()}|{goal.GetGoalScore()}");
                        }
                        }
                    }

                    Console.WriteLine("Goal list saved successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error occurred while saving the goal list: {ex.Message}");
                }
            }
            else if (choice == "4")
            {
                goalList.Clear();
                Console.WriteLine("Enter the file name you wish to load:");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);

                // Load the point total from the first line
                if (lines.Length > 0)
                {
                    pointTotal = int.Parse(lines[0]);
                }

                // Load the goals from the remaining lines
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split("|");

                    bool complete = bool.Parse(parts[0]);
                    string goalType = parts[1];
                    string goalName = parts[2];
                    string goalDescription = parts[3];
                    string almostScore = parts[4];

                    int goalScore = 0;
                    int numTimesCompleted = 0;
                    int numTimes = 0;
                    int bonusPoints = 0;

                    if (goalType == "Checklist Goal")
                    {
                        string[] completionStatus = almostScore.Split("/");
                        goalScore = int.Parse(completionStatus[0]);
                        numTimesCompleted = int.Parse(completionStatus[1]);
                        numTimes = int.Parse(completionStatus[2]);
                        bonusPoints = int.Parse(completionStatus[3]);
                    }

                    else
                    {
                        goalScore = int.Parse(almostScore);
                    }

                    // Create the appropriate Goal object based on goalType
                    Goal goal;
                    if (goalType == "Simple Goal")
                    {
                        goal = new SimpleGoal(goalType, goalName, goalDescription, goalScore, complete);
                    }
                    else if (goalType == "Eternal Goal")
                    {
                        goal = new EternalGoal(goalType, goalName, goalDescription, goalScore, complete);
                    }
                    else if (goalType == "Checklist Goal")
                    {
                        goal = new ChecklistGoal(goalType, goalName, goalDescription, goalScore, complete, numTimes, numTimesCompleted, bonusPoints);
                    }
                    else
                    {
                        // Unknown goal type, handle accordingly
                        Console.WriteLine($"Unknown goal type: {goalType}");
                        continue;
                    }

                    // Add the goal to the goalList
                    goalList.Add(goal);
                }

                Console.WriteLine("Goal list loaded successfully.");
            }



            else if (choice == "5")
            {
                Console.WriteLine("Select a goal to mark as complete:");
                for (int i = 0; i < goalList.Count; i++)
                {
                    Goal goal = goalList[i];
                    Console.WriteLine($"{i + 1}. {goal.GetGoalName()} [{(goal.IsCompleted() ? "X" : " ")}]");
                }

                Console.Write("Enter the goal number: ");
                if (int.TryParse(Console.ReadLine(), out int goalNumber))
                {
                    int goalIndex = goalNumber - 1;
                    if (goalIndex >= 0 && goalIndex < goalList.Count)
                    {
                        Goal selectedGoal = goalList[goalIndex];
                        if (!selectedGoal.IsCompleted())
                        {
                            selectedGoal.Complete();

                            pointTotal += selectedGoal.GetGoalScore();
                            Console.WriteLine($"Goal '{selectedGoal.GetGoalName()}' marked as complete. Points earned: {selectedGoal.GetGoalScore()}");

                            if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.IsCompleted())
                            {
                                pointTotal += checklistGoal.GetBonusPoints();
                                Console.WriteLine($"Bonus points earned for completing the checklist goal: {checklistGoal.GetBonusPoints()}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Goal is already marked as complete.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }            

            }

            else if (choice == "6")
            {
                // Quit the program
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
