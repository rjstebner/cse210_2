using System;

class Animation
{
    public void GetReady()
    {
        Console.Write("Activity Starting");
        List<string> readyAnimation = new List<string>
        {
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
    public void Countdown()
    {
        List<string> readyAnimation = new List<string>
        {
           "5",
           "4",
           "3",
           "2",
           "1",
           "now"
        };

        foreach (string s in readyAnimation)
        {
            Console.Write("You may begin in: " + s + "\r");
            Thread.Sleep(1000);
        }
    }
}