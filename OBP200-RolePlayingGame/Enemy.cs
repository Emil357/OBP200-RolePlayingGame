namespace OBP200_RolePlayingGame;

public class Enemy : Character{
    public string Type { get; set; }
    public int XPReward { get; set; }
    public int GoldReward { get; set; }

    public Enemy(string type, string name, int maxHealth, int attackDamage, int defense, int xpReward, int goldReward) : base(name, maxHealth, attackDamage, defense) {
        Type = type;
        XPReward = xpReward;
        GoldReward = goldReward;
    }
}