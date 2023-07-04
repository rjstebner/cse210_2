class Player
{
    private string _name;
    private int _coins;
    private int _health;
    private int _power;
    private int _armour;
    private int _potions;
    private int _potionValue;
    
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    
    public int Coins
    {
        get { return _coins; }
    }
    
    public int Health
    {
        get { return _health; }
    }
    
    public int Power
    {
        get { return _power; }
    }
    
    public int Armour
    {
        get { return _armour; }
    }
    
    public int Potions
    {
        get { return _potions; }
    }
    
    public int PotionValue
    {
        get { return _potionValue; }
    }

    public Player(string name, int coins, int health, int power, int armour, int potions, int potionValue)
    {
        _name = name;
        _coins = coins;
        _health = health;
        _power = power;
        _armour = armour;
        _potions = potions;
        _potionValue = potionValue;
    }
    public void TakeDamage(int damage)
{
    _health -= damage;
}
    public void UsePotion(int healing)
    {
        _health += healing;
        _potions -= 1;
        Console.WriteLine($"You quickly down the vial of healing and gain {healing} health");
    }
    
}
