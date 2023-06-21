public class SimpleGoal : Goal
{

    public SimpleGoal(string goalType, string goalName, string goalDescription, int goalScore, bool complete) : base(goalType, goalName, goalDescription, goalScore, complete)
    {
    }

    public override string GetGoalType()
    {
        return "Simple Goal";
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
        return _complete;
    }

        public override int GetBonusPoints()
    {
        return 0;
    }
}
