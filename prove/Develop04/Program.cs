using System;

class Program
{
    static void Main(string[] args)
    {
        Animation animation = new Animation();
        string choice = "";
        while (choice != "4")
        {
            Menu menu = new Menu();
            choice = menu.GetMenu();

            if (choice == "1")
            {
                Console.Clear();
                BreathingActivity activity = new BreathingActivity();
                int duration = activity.Starting(activity);
                activity.StartBreathingActivity(duration);
            }
            else if (choice == "2")
            {
                Console.Clear();
                ListingActivity activity = new ListingActivity();
                int duration = activity.Starting(activity);
                activity.StartListingActivity(duration);
                
            }
            else if (choice == "3")
            {
                Console.Clear();
                ReflectingActivity activity = new ReflectingActivity();
                int duration = activity.Starting(activity);
        
                activity.StartReflectingActivity(duration);
                
                
            }
            
            else if (choice == "4")
            {
                Console.WriteLine("Thank you");
            }
        }
    }
}
