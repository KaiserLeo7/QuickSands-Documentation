using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class NestDB {

        private static List<Nest> nests = new List<Nest>();

        void Awake() {
            BuildClassDatabase();
        }

        void BuildClassDatabase() 
        {
            //int id, string name, double lattitude, double longtitude, int territory, int[] nearbyTowns
            nests = new List<Nest>() {
               
                new Nest(1, "Black Rock", 100, 100, 1, new int[]{2}),
                new Nest(2, "Infested Ruins", 100,100, 2, new int[]{4}),               
                new Nest(3, "Swarming Mines", 100,100, 3, new int[]{7})
                
            };
        }
    

        //get database
        public List<Nest> getNestList() {
            return nests;
        }

     
        public Nest getNest(int position) {
            return nests[position];
        }

        //clear
        public void clearNestList() {
            nests.Clear();
        }

    }
}