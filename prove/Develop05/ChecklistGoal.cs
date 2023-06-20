public class ChecklistGoal : Goal
{
    public ChecklistGoal(string goalType, string goalName, string goalDescription, int goalScore, bool complete, int numTimes, int bonusPoints) : base(goalType, goalName, goalDescription, goalScore)
    {
        // Additional initialization or custom logic for EternalGoal
    }
    bool _complete;
    private int _numTimes;
    private int _bonusPoints;
}
