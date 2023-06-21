public class EternalGoal : Goal
{
    public EternalGoal(string goalType, string goalName, string goalDescription, int goalScore, bool complete) : base(goalType, goalName, goalDescription, goalScore, complete)
    {
        // Additional initialization or custom logic for EternalGoal
    }

    public override string GetGoalType()
    {
        return "Eternal Goal";
    }

    public override string GetGoalName()
    {
        return _goalName;
    }

    public override string GetGoalDescription()
    {
        return _goalDescription;
    }
        public override int GetGoalScore()
    {
        return _goalScore;
    }

    public override bool IsCompleted()
    {
        return false;
    }
    public override int GetBonusPoints()
    {
        return 0;
    }
    
}
