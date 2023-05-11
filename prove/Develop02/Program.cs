using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        List<Entry> journal = new List<Entry>();
        Console.WriteLine("Welcome to the Journal Program");


        while (choice != "5")
        {




            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1: Write an entry");
            Console.WriteLine("2: Display past entries");
            Console.WriteLine("3: Save your journal");
            Console.WriteLine("4: Load a journal");
            Console.WriteLine("5: Quit the program");
            Console.WriteLine("");


            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();


            if (choice == "1")


            {
                Prompt promptGenerator = new Prompt();
               
                string prompt = promptGenerator.GetRandomPrompt();


                Console.WriteLine(prompt);


                Console.Write(">");
                string response = Console.ReadLine();
                DateTime currentDate = DateTime.Today;
                Entry newEntry = new Entry(prompt, response, currentDate);

                journal.Add(newEntry);
               
            }


            else if (choice == "2")
            {
                if (journal.Count == 0)
                {
                    Console.WriteLine("No entries found.");
                }
                else
                {
                    foreach (Entry entry in journal)
                    {
                        Console.WriteLine("Date: {0}\nPrompt: {1}\nResponse: {2}", entry.Date.ToShortDateString(), entry.Prompt, entry.Response);
                        Console.WriteLine();
                    }
                }
            }
            else if (choice == "3")
            {
                Save save = new Save();
                Console.WriteLine("What would you like to call the file?");
                string saveFile = Console.ReadLine();
                save.SaveToFile(journal, saveFile);
            }


            else if (choice == "4")
            {
                Load load = new Load();
                Console.WriteLine("What file would you like load?");
                string loadFile = Console.ReadLine();
                journal = load.LoadFromFile(loadFile); // Call the LoadFromFile method
            }


            else if (choice == "5")
            {
                Console.WriteLine("See you Later! <3");
            }


            else
            {
                Console.WriteLine("I didn't quite get that, Please try again.");
            }
        }

    }
}