using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_RPG
{
    public class Game
    {
        public Hero Hero { get; set; }
        
        public Game() {
            this.Hero = new Hero();
        }
            
        public void Start() {
            Console.WriteLine("Welcome Warrior! Today you become a Hero!");
            Console.WriteLine("Please enter your name:");
            this.Hero.Name = Console.ReadLine();
            Console.WriteLine("Hello " + Hero.Name);
            this.Main();
        }
        // TODO work on User Input for Monster Choice
        public void Main() {
            Console.WriteLine("Please choose an option by entering a number.");
            Console.WriteLine("1. Check Stats");
            Console.WriteLine("2. View Inventory");
            Console.WriteLine("3. Fight Random Monster - Be a 'Hero'");
            Console.WriteLine("4. Pick Your Monster - Be a 'Sniper'");
            Console.WriteLine("5. Quit - Be a 'Coward'");
            var input = Console.ReadLine();
            if (input == "1")
            {
                this.Stats();
            }
            else if (input == "2")
            {
                this.Inventory();
            }
            else if (input == "3")
            {
                this.FightRandom();
            }
            else if (input == "4")
            {
                this.FightSpecificMonster();
                              
                //TODO create the menu to select the specific monster
                //this.Fight();
            }
            else
            {
                Environment.Exit(-1);
            }             
        }
        
        public void Stats() {
            Hero.ShowStats();
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
            Console.ReadLine();
            this.Main();
        }
        
        public void Inventory(){
            Hero.ShowInventory();
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
            Console.ReadLine();
            this.Main();
        }
        
        public void Fight(){
            var fight = new Fight(this.Hero, this);
            fight.Start();
        }

        public void FightRandom()
        {
            Random rnd = new Random();

            var fight = new Fight(this.Hero, this);
            fight.Monster = fight.Monsters[rnd.Next(fight.Monsters.Count)];
            fight.Start();
        }

        public void FightSpecificMonster()
        {
            var fight = new Fight(this.Hero, this);
            var menu = new StringBuilder();
            menu.AppendLine("Please choose from the following Monsters:");
            var loop = 0;
            for (loop = 0; loop < fight.Monsters.Count; loop++)
            {
                menu.AppendLine(string.Format("{0}. {1} ", loop + 1, fight.Monsters[loop].Name));
            }

            menu.AppendLine(string.Format("{0}. Fight last Monster in Monster Bag", ++loop));
            menu.AppendLine(string.Format("{0}. Fight 2nd Monster in Monster Bag", ++loop));
            menu.AppendLine(string.Format("{0}. Fight 1st Monster in Monster Bag with less than 20 HP", ++loop));
            menu.AppendLine(string.Format("{0}. Fight 1st Monster in Monster Bag with a strength of at least 11", ++loop));
            
            Console.Clear();
            Console.WriteLine(menu.ToString());

            //User must make a selection
            Console.Write("Make your choice: ");
            var choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                    fight.Monster = fight.Monsters[int.Parse(choice) - 1];
                    break;
                case "6":
                    fight.Monster = fight.Monsters[fight.Monsters.Count - 1];
                    break;
                case "7":
                    fight.Monster = fight.Monsters[1];
                    break;
                case "8":
                    fight.Monster = fight.Monsters.Where(x => x.CurrentHP < 20).FirstOrDefault();
                    if (fight.Monster == null)
                    {
                        fight.Monster = fight.Monsters[0];                        
                    }               
                    break;
                case "9":
                    fight.Monster = fight.Monsters.Where(x => x.Strength >= 11).FirstOrDefault();
                    if (fight.Monster == null)
                    {
                        fight.Monster = fight.Monsters[0];
                    }
                    break;
                default:
                    Console.WriteLine("You've made an invalid choice - now you will face a RANDOM monster.");
                    Random rnd = new Random();
                    fight.Monster = fight.Monsters[rnd.Next(fight.Monsters.Count)];
                    break;
                    
            }
            fight.Start();
        }
    }
}