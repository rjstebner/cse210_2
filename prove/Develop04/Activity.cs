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
        return _activityDuration;
    }

    public void GetReady()
    {
Console.Write("Activity Starting");
List<string> readyAnimation = new List<string>
{
    "Activity Starting .....",
    "Activity Starting .... ",
    "Activity Starting ...  ",
    "Activity Starting ..   ",
    "Activity Starting .    ",
    "Activity Starting Now  "
};

foreach (string s in readyAnimation)
{
    Console.Write("\r" + s);
    Thread.Sleep(1000);
}

    }
    public void ShowSpinner()
{
    List<string> spinnerAnimation = new List<string>
    {
        "|",
        "/",
        "-",
        "\\",
        "|"
    };

    foreach (string s in spinnerAnimation)
    {
        Console.Write("\r" + s);
        Thread.Sleep(500);
    }
    foreach (string s in spinnerAnimation)
    {
        Console.Write("\r" + s);
        Thread.Sleep(500);
    }
}

}