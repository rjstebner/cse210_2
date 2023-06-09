using System;

class Activity
{
    private string _activityName = "";
    private string _activityDescription = "";
    private int _activityDuration;
    public Activity(string activityName, string activityDescription, int activityDuration)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _activityDuration = activityDuration;

    }
    public string GetName()
    {
        return "Welcome to the " + _activityName;
    }
    public string GetDescription()
    {
        return _activityDescription;
    }
    public int GetDuration()
    {
        Console.Write("In seconds, about how long would you like your session to last? ");
        int activityDuration;
        if (int.TryParse(Console.ReadLine(), out activityDuration))
        {
            Console.Clear();
            _activityDuration = activityDuration;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid duration in seconds.");
        }
        return activityDuration;
    }
    public int Starting(Activity activity)
    {
                Console.WriteLine(activity.GetName());
                Console.WriteLine("");
                Console.WriteLine(activity.GetDescription());
                Console.WriteLine("");
                int activityDuration = activity.GetDuration();
                Animation animation = new Animation();
                animation.GetReady();
                
                return activityDuration;
    }


}