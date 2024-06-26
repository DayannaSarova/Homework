﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Knight : Hero
    {
        private const int BlockDamageChance = 10;
        private const int ExtraDamageChance = 5;

        public Knight(string name) : base(name) { }

        public override void TakeDamage(int incomingDamage)
        {
            int damageReduceCoef = Random.Next(20, 61);
            incomingDamage -= (incomingDamage * damageReduceCoef) / 100;
            if (ThrowDice(BlockDamageChance)) incomingDamage = 0;
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(ExtraDamageChance)) attack = attack * 150 / 100;
            return attack;
        }

        private bool ThrowDice(int chancePercent)
        {
            return Random.Next(100) < chancePercent;
        }
    }
}
