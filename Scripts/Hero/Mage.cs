using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script sets the values of the unit and its animation
namespace Sands
{
    public class Mage : Hero
    {

    public Mage( int damage, double critDamage, int maxHP, int currentHP) : base(damage, critDamage, maxHP, currentHP){ }

        public override bool TakeDamage(int dmg)
        {
            CurrentHP -= dmg;

            if (CurrentHP <= 0)
            {
                CurrentHP = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Heal(int healAmount)
        {
            CurrentHP += healAmount;
            if (CurrentHP > MaxHP)
                CurrentHP = MaxHP;
        }

        public int GetHealth()
        {
            return CurrentHP;
        }

    }
}