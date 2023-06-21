public class ChecklistGoal : Goal
{
    private int _numTimes;
    private int _bonusPoints;
    private int _numTimesCompleted;

    public ChecklistGoal(string goalType, string goalName, string goalDescription, int goalScore, bool complete, int numTimes, int numberTimesCompleted, int bonusPoints) : base(goalType, goalName, goalDescription, goalScore, complete)
    {
        _numTimes = numTimes;
        _bonusPoints = bonusPoints;
        _numTimesCompleted = 0;
    }

    public override string GetGoalType()
    {
        return "Checklist Goal";
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
        public override int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public int NumTimes
    {
        get { return _numTimes; }
    }

    public int NumTimesCompleted
    {
        get { return _numTimesCompleted; }
        set { _numTimesCompleted = value; }
    }

    public override bool IsCompleted()
    {
        return _numTimesCompleted >= _numTimes;
    }
        public override void Complete()
    {
        base.Complete();
        _numTimesCompleted++;
    }
    public override string ToString()
    {
        return $"{base.ToString()} | Times Completed: {_numTimesCompleted}/{_numTimes}";
    }



}
