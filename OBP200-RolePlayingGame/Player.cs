namespace OBP200_RolePlayingGame;

public class Player : Character, IDoRest{
    public bool DoRest() {
        Console.WriteLine("Du slår läger och vilar.");
        CurrentHealth = MaxHealth;
        Console.WriteLine("HP återställt till max.");
        return true;
    }
    public string TypeOfCharacter { get; set; }
    public int Potions { get; set; }
    public int Gold { get; private set; }
    public int Xp { get; private set; }
    public int Level { get; private set; }
    
    
    public List<string> Inventory { get; set; }

    public Player(string name, string typeOfCharacter, int maxHealth, int attackDamage, int defense, int potions, int gold, List<string> startingInventory) : base(name, maxHealth, attackDamage, defense) {
        TypeOfCharacter = typeOfCharacter;
        Potions = potions;
        Gold = gold;
        Xp = 0;
        Level = 1;
        Inventory = startingInventory;
    }
    public void AddGold(int amount)
    {
        if (amount > 0) Gold += amount;
    }

    public void AddXp(int amount) {
        if (amount > 0)
        {
            Xp += amount;
        }
    }
}