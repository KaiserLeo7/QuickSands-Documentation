using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class EnemyBoss : Enemy
    {


        public EnemyBoss(int damage, double critDamage, int maxHealth, int currentHealth) : base(damage, critDamage,maxHealth, currentHealth) { }

        //what distinguishes bosses? Maybe an ability?
        /*public ability()
        {

        }*/

    }
}