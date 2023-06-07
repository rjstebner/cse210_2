using System;
using System.Threading;

class ListingActivity : Activity
{
    static string listingDescription = "This activity will help you relax by clearing you mind and focusing only on your breath.";
    public ListingActivity() : base("Listing Activity", listingDescription, 20)
    {
    }

}
