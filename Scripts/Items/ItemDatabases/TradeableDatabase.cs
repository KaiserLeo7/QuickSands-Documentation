using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sands
{
    public class TradeableDatabase
    {

        private List<Tradeable> tradeables = new List<Tradeable>();

        //get database
        public List<Tradeable> getTradeableList()
        {
            return tradeables;
        }

        void BuildClassDatabase()
        {
            tradeables = new List<Tradeable>() {
                //(itemName, weight, price)
                new Tradeable("Metals", 4, 40.0),
                new Tradeable("Silver", 5, 50.0),
                new Tradeable("Gold", 6, 60.0),
                new Tradeable("Diamonds", 7, 100.0),
                new Tradeable("Leather", 1, 10.0),
                new Tradeable("Rations", 2, 20.0),
                new Tradeable("Spices", 3, 30.0)
            };
        }

        //get Hero at position
        public Tradeable getTradeable(int position)
        {
            return tradeables[position];
        }

        //delete
        public List<Tradeable> deleteTradeable(Tradeable tradeable)
        {
            return tradeables = tradeables.Except(tradeables.Where(t => t.ItemName == tradeable.ItemName)).ToList();
        }

        //clear
        public void clearTradeableList()
        {
            tradeables.Clear();
        }
    }
}
