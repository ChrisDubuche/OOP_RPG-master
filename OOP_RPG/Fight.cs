using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{
    public class Fight
    {
        public List<Monster> Monsters { get; set; }
        public Game Game { get; set; }
        public Hero Hero { get; set; }
        public Monster Monster { get; set; }
        
        public Fight(Hero hero, Game game) {
            this.Monsters = new List<Monster>();
            this.Hero = hero;
            this.Game = game;
            this.AddMonster("Cracken", 9, 8, 20, 4);
            // added new monsters as per OOP RPG instructions
            this.AddMonster("Lion", 9, 6, 10, 2);
            this.AddMonster("Wolf", 7, 9, 15, 3);
            this.AddMonster("Dragon", 11, 10, 25, 5);
            this.AddMonster("Stag", 8, 9, 12, 2);
        }
        
        public void AddMonster(string name, int strength, int defense, int hp, int gold) {
            #region
            //var monster = new Monster();
            //monster.Name = name;
            //monster.Strength = strength;
            //monster.Defense = defense;
            //monster.OriginalHP = hp;
            //monster.CurrentHP = hp;
            #endregion
            var monster = new Monster(name, strength, defense, hp, hp, gold);
            this.Monsters.Add(monster);
        }

        public void Start()
        {
            #region Tips to select specific monsters
            // first monster - var enemy = Monsters[0];
            // last monster - var enemy = Monsters[Monsters.Count - 1];
            // first monster with less than 20 hp - use linq method
            // var enemy = Monsters.Where(x => x.CurrentHP < 20).FirstOrDefault();*/ //research why FirstOrDefault is a good option
            // alt method of lambda expression - var enemy = Monsters.Find(x => x.CurrentHP < 20);

            // first monster with a stregnth of at least 11
            /*var enemy = Monsters.Where(x => x.Strength >= 11).FirstOrDefault();*/ // research alt method to achieve this result

            // last monster alt method
            //var enemy = this.Monsters[Monsters.Count -1];
            //second monster
            //var enemy = Monsters[1];
            #endregion            
       
            Console.WriteLine("You've encountered a " + Monster.Name + "! " + Monster.Strength + " Strength/" + Monster.Defense + " Defense/" +
            Monster.CurrentHP + " HP. What will you do?");
            Console.WriteLine("1. Fight");
            Console.WriteLine("2. Attempt to Flee to Main Menu");
            //TODO - create a speed properties in both the monster and hero so if the hero flees he must be faster to survive or if he's slower he dies
            var input = Console.ReadLine();
            if (input == "1")
            {
                this.HeroTurn();
            }          
            else
            {
                this.Game.Main();
            }
        }
        
        public void HeroTurn(){
          
           var compare = Hero.Strength - Monster.Defense;
           int damage;
           
           if(compare <= 0) {
               damage = 1;
               Monster.CurrentHP -= damage;
           }
           else{
               damage = compare;
               Monster.CurrentHP -= damage;
           }
           Console.WriteLine("You did " + damage + " damage!");
           
           if(Monster.CurrentHP <= 0){
               this.Win();
           }
           else
           {
               this.MonsterTurn();
           }
           
        }
        
        public void MonsterTurn(){
           int damage;
           var compare = Monster.Strength - Hero.Defense;
           if(compare <= 0) {
               damage = 1;
               Hero.CurrentHP -= damage;
           }
           else{
               damage = compare;
               Hero.CurrentHP -= damage;
           }
           Console.WriteLine(Monster.Name + " does " + damage + " damage!");
           if(Hero.CurrentHP <= 0){
               this.Lose();
           }
           else
           {
               this.HeroTurn();
           }
        }
        
        public void Win() {
            
            Console.WriteLine(Monster.Name + " has been defeated! You win the battle!");
            Game.Main();
        }
        // TODO - think about what the user can or should do once they've died - make it a new game 
        // - can they restart with fresh health or should they go to the store
        public void Lose() {
            Console.WriteLine("You've died in Battle! :( GAME OVER.");
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadLine();
            //TODO Learn to reset the game from scratch with refreshed HP, strength etc
            this.Game.Main();  
        }

    }
    
}