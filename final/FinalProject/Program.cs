using System;
using System.IO;

class Program
{
    public static Player player;

    static void Main(string[] args)
    {
        Start();
        Encounters.FirstEncounter();
    }

    static void Start()
    {
        Console.WriteLine("Welcome to Randy's Fantastic Dungeon Crawl!");
        Console.WriteLine("What is your name? ");
        string playerName = Console.ReadLine();
        player = new Player(playerName, 0, 10, 1, 0, 3, 3);
        Console.Clear();
    }

    static void SaveToFile()
    {
        string filename = "randydungeon.txt";
        string save = $"{player.Name},{player.Coins},{player.Health},{player.Power},{player.Armour},{player.Potions},{player.PotionValue}";
        File.WriteAllText(filename, save);
        Console.WriteLine("Player information saved to file.");
    }

    static void LoadFromFile()
    {
        string filename = "randydungeon.txt";
        if (File.Exists(filename))
        {
            string save = File.ReadAllText(filename);
            string[] saveData = save.Split(',');

            if (saveData.Length == 7)
            {
                string playerName = saveData[0];
                int coins = int.Parse(saveData[1]);
                int health = int.Parse(saveData[2]);
                int power = int.Parse(saveData[3]);
                int armour = int.Parse(saveData[4]);
                int potions = int.Parse(saveData[5]);
                int potionValue = int.Parse(saveData[6]);

                player = new Player(playerName, coins, health, power, armour, potions, potionValue);
                Console.WriteLine("Player information loaded from file.");
            }
            else
            {
                Console.WriteLine("Invalid save file format.");
            }
        }
        else
        {
            Console.WriteLine("Save file not found.");
        }
    }
}
