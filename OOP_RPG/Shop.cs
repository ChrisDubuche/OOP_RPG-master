using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    class Shop
    {
        List<Armor> ShopArmor { get; set; }
        List<Weapon> ShopWeapons { get; set; }
        List<Potion> ShopPotions { get; set; }
     
        //TODO : Create a StockMyShop Method that calls an overloaded Stock method 
        // - stock is overloaded because it has the same name but carries different functions

        public void StockMyShop()
        {

        }

        // TODO : Add a constructor to initalize all the empty lists

        public Shop()
        {
            StockMyShop();
        }
    }

}
