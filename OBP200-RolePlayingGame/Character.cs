namespace OBP200_RolePlayingGame;

public abstract class Character {
    public string Name { get; set; }
    public int MaxHealt { get; set; }
    public int CurrentHealt { get; set; }
    public int AttackDamage { get; set; }
    public int Defense { get; set; }
    
    public Character(string name, int maxHealt, int attackDamage,  int defense) {
        Name = name;
        MaxHealt = maxHealt;
        CurrentHealt = maxHealt;
        AttackDamage = attackDamage;
        Defense = defense;
    }
}