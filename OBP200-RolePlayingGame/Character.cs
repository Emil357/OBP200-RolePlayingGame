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
    public void TakeDamage(int damage) {
        if (damage < 0) damage = 0;
        CurrentHealth -= damage;
        if (CurrentHealth < 0) CurrentHealth = 0;
    }
    public void Heal(int amount) {
        if (amount < 0) amount = 0;
        CurrentHealth += amount;
        if (CurrentHealth > MaxHealth) CurrentHealth = MaxHealth;
    }
}