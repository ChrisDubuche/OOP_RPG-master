Object-Oriented Programming Exercises for C#

This application is for familiarizing yourself with object-oriented programming and C# through a series of exercises. You will be improving a text-based role-playing game. 

To get started, clone this repo or download the files. You will be able to interact with this program using the console shell in Visual Studio or via the bash command line using mono.

To view the completed solution for the following projects, checkout the branch solution-implement-shop.

**** PROJECT: Improve the Initial Application ****

Challenge: Call a Method

Our Fight class is pretty boring right now. There is only one monster a hero can fight. In the constructor, add at least 3 more monsters a hero could fight.

Challenge: Access List Items

In the Start method, the hero is fighting the first monster in the list. Can you make it so the hero instead fights:

1) The last monster

2) The second monster

3) The first monster with less than 20 hitpoints

4) The first monster with a strength of at least 11

5) A random monster

Challenge: Add a Constructor

In the AddMonster method of our Fight class, we are setting each property of our monster object individually. This isn't a big deal now, but what if we wanted to initialize a new instance of our Monster class somewhere else? There is a quicker way to do this. 

Add a constructor to the Monster class. It should set the Name, Strength, Defense, OriginalHP, and CurrentHP according to parameters that are passed in. Refactor the AddMonster method of the Fight class to reflect this change. 

Challenge: Add a Property

It looks like we have some repeated code in our Fight class. The HeroTurn, MonsterTurn, and Win methods are all passing around the same instance of Monster that we initialized in the Start method. There must be an easier, more DRY way to do this. 
Add a monster property to the Fight class. The monster should be passed in as an argument to the constructor when a new Fight is initialized. Refactor the code so that this property is being referred to, instead of passing around a Monster object from method to method. 

**** PROJECT: Add a Shop, Gold, and New Items ****

We want to add a few new features to our RPG. First, we want the hero to be able to visit a shop where he/she can buy items such as weapons, armor, and healing potions. Second, we want the hero to earn gold for every monster he/she defeats.

Challenge: Add a Property

Add Gold property to your Hero and Monster classes. This should be a data type of intent. In your Hero constructor, initialize the Gold property to equal 0. When an instance of the Monster class is created, the Gold property should be set to equal 5.

Challenge: Modify a Method

In the Fight class, edit the Win method so that the amount associated with the monster’s Gold property is added to the Heros Gold.

Challenge: Create a Class

Create a Potion class. This should contain a property HP of type int and a Name property of type string. In the constructor, set the HP and Name to the arguments that are passed into the constructor.

Create a Shop class. This should contain a list of Weapons, a list of Armor, and a list of Potions. Don't forget to initialize empty lists in the constructor!

Challenge: Create an Interface

The Potion, Weapon, and Armor classes are missing important properties. Somehow we need to specify how much these items cost. Since we may create more items in the future, let’s create an Interface called Item. This should have two int properties: OriginalValue and ResellValue. 

Set up your Weapon, Armor, and Potion classes to inherit from the Item interface. For each class, implement the new properties and allow them to be set by the constructor. 

**** PROJECT: Implement Your Shop ****
** This is currently under construction and is not completely accurate. You can still use the steps below as general guidelines for implementing the shop feature. **

Challenge: Add Items to a List

In the Game class, add a Shop property and a method InitializeShop. In InitializeShop, set the Game's shop to a new Shop and stock up the shop with the following:

Weapons

(Name, OriginalValue, ResellValue, Strength)

Sword, 10, 2, 3

Axe, 12, 3, 4

Longsword: 20, 5, 7

Armor

(Name, OriginalValue, ResellValue, Defense)

Wooden Armor, 10, 2, 3

Metal Armor, 20, 5, 7

Potions

(Name, HP)

Healing Potion, 5

Challenge: Add Methods

Let's add some methods to get the shop up and running.

Menu():

This should display a welcome message.

Welcome to my shop! What would you like to do?

1) Buy Item

2) Sell Item

3) Return to Game Menu

If the user enters 1, call the ShowInventory method. If the user enters 2, call the BuyfromUser method. If the user enters anything else, they should be sent back to the game's Main method.

ShowInventory():

This should loop through each list and display the Name and OriginalValue. A number should correspond with each item. If the user enters an item’s number, call the Sell method. If the user enters “r� or returnee, it should return them to the Menu. These directions should be given to the user so they know what to enter.


BuyfromUser():

This should loop through each of the hero's lists and display the Name and ResellValue. A number should correspond with each item. If the user enters an items number, call the Buy method. If the user enters “r�? or return, it should return them to the Menu. These directions should be given to the user so they know what to enter.

Sell(int itemNumber):

This should remove the specified item from the hero's bag. It should add the corresponding ResellValue to the hero's gold.
Then the user should be returned to Menu.

Congrats! You've added a cool new feature to your RPG! 

If you're looking for another challenge, here are some other features to consider:
- Allow a hero to equip a weapon or armor. Add the item's strength or defense to the hero's stats and take that into account when the hero fights a monster.
- Allow a hero to use a healing potion to regain HP.
- Add a speed property to your hero and monsters. Allow the hero to run away from a monster if his/her speed is higher than the monster's speed.
