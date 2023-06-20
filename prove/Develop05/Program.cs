using System;
public class Program
{
    static void Main(string[] args)
    {
        CreateGoal g = new CreateGoal(); // Instantiate an object of type Goal

        string goalType = g.GetGoalType();
        string goalName = g.GetGoalName();
        string goalDescription = g.GetGoalDescription();
        int goalScore = g.GetGoalScore();

        SimpleGoal g1 = new SimpleGoal(goalType, goalName, goalDescription, goalScore, false);

        // Rest of your code
    }
}
