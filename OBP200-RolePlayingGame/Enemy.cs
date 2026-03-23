namespace OBP200_RolePlayingGame;

public class Enemy {
    public string Type { get; set; }
    public string Name { get; set; }
    public int MaxHealth { get; set; }
    public int CurrentHealth { get; set; }
    public int AttackDamage { get; set; }
    public int Defense { get; set; }
    public int XPReward { get; set; }
    public int GoldReward { get; set; }

    public Enemy(string type, string name, int maxHealth, int attackDamage, int defense, int xpReward, int goldReward) {
        Type = type;
        Name = name;
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;
        AttackDamage = attackDamage;
        Defense = defense;
        XPReward = xpReward;
        GoldReward = goldReward;
    }
}