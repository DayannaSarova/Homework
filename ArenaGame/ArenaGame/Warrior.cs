using System;

public class Warrior
{
    public class Warrior : Hero
    {
        private const int BerserkAttackChance = 20; 

        public Warrior(string name) : base(name) { }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(BerserkAttackChance))
            {
                attack *= 2;
            }
            return attack;
        }

    }
