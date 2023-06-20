using System;
using System.Collections.Generic;

public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    private string _goalType;
    private int _goalScore;

    public Goal(string goalType, string goalName, string goalDescription, int goalScore)
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalScore = goalScore;
    }

    
    public List<string> ListGoals()
    {
        // Implementation to list goals
        
        return new List<string>(); // Placeholder return statement
    }
}
