using System;
namespace OOP_RPG
{
    public static class Tests
    {
            public static void Run() {
                
                var hero = new Hero();
                hero.Strength = 55;
                
                Console.WriteLine("Hero's strength: " + hero.Strength);
                
                var weapon = new Weapon("Sword", 8);
                Console.WriteLine("Weapon is a " + weapon.Name + " of strength " + weapon.Strength);
                hero.WeaponsBag.Add(weapon);
                var weapon2 = new Weapon("Axe", 10);
                hero.WeaponsBag.Add(weapon2);
                
                foreach (var item in hero.WeaponsBag) {
                    Console.WriteLine(item.Name);
                }
            }
    }
}