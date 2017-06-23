using System;
namespace OOP_RPG
{
    public class Weapon
    {
        public Weapon(string name, int strength) {
            this.Name = name;
            this.Strength = strength;
        }
        
        public string Name { get; set; }
        public int Strength { get; set; }
    }
}