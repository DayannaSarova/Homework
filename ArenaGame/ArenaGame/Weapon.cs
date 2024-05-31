using System;

public abstract class Weapon
{
    public string Name { get; }
    public int AttackBoost { get; }

    protected Weapon(string name, int attackBoost)
    {
        Name = name;
        AttackBoost = attackBoost;
    }
}

public class Sword : Weapon
{
    public Sword() : base("Sword", 10) { }
}

public class Axe : Weapon
{
    public Axe() : base("Axe", 15) { }
}

public class Bow : Weapon
{
    public Bow() : base("Bow", 8) { }
}
