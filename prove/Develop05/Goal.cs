using System;
using System.Collections.Generic;

public abstract class Goal
{
    public string _goalName;
    public string _goalDescription;
    public string _goalType;
    public int _goalScore;
    public bool _complete;

    public Goal(string goalType, string goalName, string goalDescription, int goalScore, bool complete)
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalScore = goalScore;
        _complete = complete;
    }

    public virtual void Complete()
    {
        _complete = true;
    }
    
    public abstract int GetBonusPoints();

    public abstract string GetGoalType();
    public abstract string GetGoalName();
    public abstract string GetGoalDescription();
    public abstract int GetGoalScore();
    public abstract bool IsCompleted();


    public override string ToString()
    
    {
        return $"Goal Type: {GetGoalType()} | Completed: {IsCompleted()} | Name: {GetGoalName()} | Description: {GetGoalDescription()}  Score: {GetGoalScore()}";
    }
}
