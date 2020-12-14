﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sands {
    public class EnemyDatabase {

        private static List<Enemy> enemies = new List<Enemy>();

        //get database
        public List<Enemy> getEnemyList() {
            return enemies;
        }

        //get Hero at position
        public Enemy getEnemy(int position) {
            return enemies[position];
        }

        //delete
        public List<Enemy> deleteEnemy(Enemy enemy) {
            return enemies = enemies.Except(enemies.Where(e => e.EnemyName == enemy.EnemyName)).ToList();
        }

        //clear
        public void clearEnemyList() {
            enemies.Clear();
        }

    }
}

