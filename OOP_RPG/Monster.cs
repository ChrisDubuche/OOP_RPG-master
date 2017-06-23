using System;
using System.Collections.Generic;

namespace OOP_RPG
{
    public class Monster
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int OriginalHP { get; set; }
        public int CurrentHP { get; set; }
        public int Gold { get; set; }


        // TODO add constructor as per OOP RGP instructions

        public Monster()
        { }
        public Monster(string name, int strength, int defense, int origHP, int currHP, int gold)
        {
            this.Name = name;
            this.Strength = strength;
            this.Defense = defense;
            this.OriginalHP = origHP;
            this.CurrentHP = currHP;
            this.Gold = gold;
        }
    }
}
