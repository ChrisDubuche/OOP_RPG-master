using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public class Potion 
    {
        public string Name { get; set; }
        public int CurrentHP { get; set; }
        
        public Potion(string name, int currentHP) {
            this.Name = name;
            this.CurrentHP = currentHP;
        }

    }
}
