using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Rogue : Hero
    {
        prprivate const int TripleDamageMagicLastDigit = 5;
        private const int HealEachNthRound = 3;
        private int attackCount;

        public Rogue(string name) : base(name)
        {
            attackCount = 0;
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (attack % 25 == TripleDamageMagicLastDigit)
            {
                attack *= 3;
            }
            attackCount++;
            if (attackCount % HealEachNthRound == 0 && ThrowDice(25))
            {
                Heal(StartingHealth * 50 / 100);
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(30)) incomingDamage = 0;
            base.TakeDamage(incomingDamage);
        }

        private bool ThrowDice(int chancePercent)
        {
            return Random.Next(100) < chancePercent;
        }

        private void Heal(int amount)
        {
            Health += amount;
            if (Health > StartingHealth) Health = StartingHealth;
        }
    }
}
