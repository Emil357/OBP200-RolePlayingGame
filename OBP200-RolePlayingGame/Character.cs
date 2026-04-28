namespace OBP200_RolePlayingGame;

public abstract class Character {
    public string Name { get; set; }
    public int MaxHealth { get; set; }
    public int CurrentHealth { get; protected set; }
    public int AttackDamage { get; set; }
    public int Defense { get; set; }
    
    public Character(string name, int maxHealth, int attackDamage,  int defense) {
        Name = name;
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;
        AttackDamage = attackDamage;
        Defense = defense;
    }
    
    public void TakeDamage(int damage)
    {
        int finalDamage = Math.Max(0, damage);
        CurrentHealth -= finalDamage;
        
        if (CurrentHealth < 0) CurrentHealth = 0;
        
        Console.WriteLine($"{Name} tog {finalDamage} skada. HP: {CurrentHealth}/{MaxHealth}");
    }
}