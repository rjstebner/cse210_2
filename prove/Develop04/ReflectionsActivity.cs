using System;
using System.Threading;

class RelfectionActivity : Activity
{
    static string reflectionDescription = "This activity will help you relax by clearing you mind and focusing only on your breath.";
    public RelfectionActivity() : base("reflection Activity", reflectionDescription, 20)
    {
    }

}
