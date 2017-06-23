using System;
namespace OOP_RPG
{
    public class Armor
    {
        public string Name { get; set; }
        public int Defense { get; set; }

        public Armor(string name, int defense) {
            this.Name = name;
            this.Defense = defense;
        }
               
    }
}