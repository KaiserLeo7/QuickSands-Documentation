using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Sands {
    public class HeroClassDB : MonoBehaviour {

        public List<Hero> heroes = new List<Hero>();

        void Awake() {
            BuildClassDatabase();
        }

        void BuildClassDatabase() 
        {
            heroes = new List<Hero>() {
                //adding all 3 types off heroes to sample class
                //  int damage, double critDamage, int maxHP, int currentHP
                   new Warrior( 100, 10.0, 500, 500, 100),
                   new Ranger(   50, 33.0, 350, 350, 75),
                   new Mage(    250, 15.0, 200, 200, 60)
            };
        }

        //get database
        public List<Hero> getHeroList() {
            return heroes;
        }

        //get Hero at position
        public Hero getHero(int position) {
          return heroes[position];
        }

        //clear
        public void clearHeroList() {
            heroes.Clear();
        }
    }
}