namespace OBP200_RolePlayingGame;

public class Player : Character, IDoRest{
    public string TypeOfCharacter { get; set; }
    public int Potions { get; private set; }
    public int Gold { get; set; }
    public int Xp { get; set; }
    public int Level { get; set; }
    
    
    public List<string> Inventory { get; set; }

    public Player(string name, string typeOfCharacter, int maxHealth, int attackDamage, int defense, int potions, int gold, List<string> startingInventory) : base(name, maxHealth, attackDamage, defense) {
        TypeOfCharacter = typeOfCharacter;
        Potions = potions;
        Gold = gold;
        Xp = 0;
        Level = 1;
        Inventory = startingInventory;
    }
    public bool DoRest() {
        Console.WriteLine("Du slår läger och vilar.");
        Heal(MaxHealth);
        Console.WriteLine("HP återställt till max.");
        return true;
    }
    public void UsePotion() {
        if (Potions <= 0) {
            Console.WriteLine("Du har inga drycker kvar.");
            return;
        }
        int healAmount = 12;
        int oldHp = CurrentHealth;
        
        Heal(healAmount);
        Potions--;

        Console.WriteLine($"Du dricker en dryck och återfår {CurrentHealth - oldHp} HP.");
    }
    public void AddPotion() {
        Potions++;
    }
}