using System;
using System.Collections.Generic;

namespace PitFighters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string[] choices = new string[] {"A", "B", "C", "D", "E" }; // make selection easy
            

            // start the loop for a new game
            while (true)
            {
                // variables for each round
                //string[] teamANames = new string[5]; // names the player will choose
                string[] teamBNames = new string[] {"Artemis the Elegant", "Oberyn the Quick", "The Red Knight", "Evil Ezma",
            "Athene Athame"}; // chosen by computer
                List<Fighter> teamAFighters = new List<Fighter>(); // Team A fighters
                List<Fighter> teamBFighters = new List<Fighter>(); // Team B fighters
                List<string> weapons = new List<string> { "Crossbow", "Spear", "Sword & Shield", "Warhammer", "Dagger" };

                // populate Team B
                for (int i = 0; i < weapons.Count; i++)
                {
                    teamBFighters.Add(new Fighter(teamBNames[i], weapons[i]));
                }

                // Intro to user
                Console.WriteLine("Welcome to Pit Fighter");
                Console.WriteLine("\nYour team will have 5 fighters and so will the other team.");
                Console.WriteLine("Each fighter has their own weapon and their opponents are chosen randomly.");
                Console.WriteLine("\nGood luck!\n");

                // Ask for names and weapons of Team A fighters, put into list - use loop
                for (int i = 0; i < choices.Length; i++)
                {
                    // variables
                    string name = "";
                    string weapon = "";
                    int weaponNum = -1;
                    bool validEntry = false;

                    // get the name
                    while (String.IsNullOrEmpty(name)) // keep asking for name until they enter something
                    {
                        Console.Write($"\nEnter a name for Fighter {choices[i]}: ");
                        name = Console.ReadLine();
                    }

                    // Get the weapon
                    Console.WriteLine("\nHere are the weapons to choose from:");
                    // Display list of weapons left to choose from
                    DisplayWeapons(choices, weapons);

                    // loop until they enter a letter
                    while (String.IsNullOrEmpty(weapon) || !validEntry) // check validity
                    {
                        Console.Write($"\nEnter the letter of {name}'s weapon: ");
                        weapon = Console.ReadLine();
                        // check if they entered a letter equal to any of the weapon choices - lots of loops
                        for (int n = 0; n < weapons.Count; n++)
                        {
                            if (weapon.ToUpper().Equals(choices[n]))
                            {
                                validEntry = true; // if it matches one of the valid choice letters, it allows
                                                   // the while loop to break. This ensures the user enters a valid letter.
                               
                                // set the weapon num to that index so that the name of the weapon can be changed to its real name
                                weaponNum = n;

                                // change "weapon" to actual name of weapon
                                weapon = weapons[weaponNum];

                                break; // if one is found to be valid, it can break the for loop.
                            }
                        }
                    }
                    

                    // now create a new fighter to add to the team
                    teamAFighters.Add(new Fighter(name, weapon));

                    // delete that weapon from list of weapons
                    weapons.RemoveAt(weaponNum); // if it stays -1, there's an error

                    // now it will loop to find the name and weapon of the next fighter of the next fighter
                    Console.WriteLine("\nFighter created!");
                }

                // show them their team
                Console.WriteLine("\nHere is your team and their weapons:\n");
                DisplayFighters(teamAFighters);

                // Show them the enemy team
                Console.WriteLine("\nHere is the enemy team:\n");
                DisplayFighters(teamBFighters);


                Console.WriteLine("\nFighters will be chosen randomly.\nHere we go!");

                // Start the battle

                // Choose opponents randomly

            }


        }

        // display weapons
        public static void DisplayWeapons(string[] choices, List<string> weapons)
        {
            for (int i = 0; i < weapons.Count; i++) //this will only show weapons left to pick from
            {
                Console.WriteLine($"{choices[i]}. {weapons[i]}");
            }
        }

        // display fighters on a team
        public static void DisplayFighters(List<Fighter> fighters)
        {
            for(int i = 0; i < fighters.Count; i++) //this will only show fighters left on team
            {
                Console.WriteLine($"{fighters[i].GetName()} - {fighters[i].GetWeapon()}");
            }
        }


        // method to get the outcome of the fight
        // if fighter A wins, fighter B is removed from list
        // if fighter B wins, fighter A is removed from list
        // if it's a tie, both fighters are removed

    }



}
