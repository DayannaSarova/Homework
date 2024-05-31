using System;

public class Mage
{
    public class Mage : Hero
    {
        private const int MagicAttackMultiplier = 125; 

        public Mage(string name) : base(name) { }

        public override int Attack()
        {
            int attack = base.Attack();
            return attack * MagicAttackMultiplier / 100;
        }
    }
}
