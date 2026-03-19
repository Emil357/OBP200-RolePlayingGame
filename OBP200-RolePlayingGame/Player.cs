namespace OBP200_RolePlayingGame;

public class Player {
    public string Name { get; set; }
    public string TypeOfCharacter { get; set; }
    public int MaxHealth { get; set; }
    public int CurrentHealth  { get; set; }
    public int AttackDamage { get; set; }
    public int Defense { get; set; }
    public int Potions { get; set; }
    public int Gold { get; set; }
    public int Xp { get; set; }
    public int Level { get; set; }
    
    
    public List<string> Inventory { get; set; }

    public Player(string name, string typeOfCharacter, int maxHealth, int attackDamage, int defense, int potions, int gold, List<string> startingInventory) {
        Name = name;
        TypeOfCharacter = typeOfCharacter;
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;
        AttackDamage = attackDamage;
        Defense = defense;
        Potions = potions;
        Gold = gold;
        Xp = 0;
        Level = 1;
        Inventory = startingInventory;
    }
}