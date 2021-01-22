using System;
using System.Collections.Generic;

namespace PitFighters
{
    class Program
    {
        static void Main()
        {
            // Variables
            string[] choices = new string[] {"A", "B", "C", "D", "E" }; // make selection easy
            

            // start the loop for a new game
            while (true)
            {
                // variables for each round
                //string[] teamANames = new string[5]; // names the player will choose
                //string[] teamBNames = new string[] {"Artemis the Elegant", "Oberyn the Quick", "The Red Knight", "Evil Ezma",
            //"Athene Athame"}; // chosen by computer
                List<Fighter> teamAFighters = new List<Fighter>(); // Team A fighters
                List<Fighter> teamBFighters = new List<Fighter>(); // Team B fighters
                List<string> teamAWeapons = new List<string> { "Crossbow", "Spear", "Sword & Shield", "Warhammer", "Dagger" };
                List<string> teamBWeapons = new List<string> { "Crossbow", "Spear", "Sword & Shield", "Warhammer", "Dagger" };
                Random random = new Random(); // generate random numbers
                string cont;

                // Intro to user
                Console.WriteLine("\nWelcome to Pit Fighter");
                Console.WriteLine("\nBoth teams will have 5 fighters.");
                Console.WriteLine("Fighters are chosen randomly, but each player may choose their weapon.");
                Console.WriteLine("\nGood luck!\n");

                Console.WriteLine("Player 1, please name your fighters.");
                // Ask for names and weapons of Team A fighters, put into list - use loop
                for (int i = 0; i < choices.Length; i++)
                {
                    // variables
                    string name = "";
                    

                    // get the name
                    while (String.IsNullOrEmpty(name)) // keep asking for name until they enter something
                    {
                        Console.Write($"Enter a name for Fighter {choices[i]}: ");
                        name = Console.ReadLine();

                        if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name))
                        {
                            Console.WriteLine("Invalid entry.");
                        }
                    }
                    

                    // now create a new fighter to add to the team
                    teamAFighters.Add(new Fighter(name));


                    // now it will loop to find the name and weapon of the next fighter of the next fighter
                    //Console.WriteLine("\nFighter created!");
                }

                Console.WriteLine("\nPlayer 2, please name your fighters.");
                // Ask for names and weapons of Team B fighters, put into list - use loop
                for (int i = 0; i < choices.Length; i++)
                {
                    // variables
                    string name = "";


                    // get the name
                    while (String.IsNullOrEmpty(name)) // keep asking for name until they enter something
                    {
                        Console.Write($"Enter a name for Fighter {choices[i]}: ");
                        name = Console.ReadLine();
                    }


                    // now create a new fighter to add to the team
                    teamBFighters.Add(new Fighter(name));


                    // now it will loop to find the name and weapon of the next fighter of the next fighter
                    //Console.WriteLine("\nFighter created!");
                }


                Console.WriteLine("\nFighters will be chosen randomly.\nHere we go!");

                // Start the battle

                // Loop until there are no team members left on one team
                while (teamAFighters.Count > 0 && teamBFighters.Count > 0)
                {
                    // Variables
                    //int index1 = random.Next(0, teamAFighters.Count);
                    //int index2 = random.Next(0, teamBFighters.Count);
                    Fighter fighter1 = teamAFighters[random.Next(0, teamAFighters.Count)]; // grab random fighter
                    Fighter fighter2 = teamBFighters[random.Next(0, teamBFighters.Count)]; // grab random fighter
                    //int whoPicks;

                    // take a pause
                    Console.WriteLine("\n(Hit enter to continue.)");
                    Console.ReadLine();

                    // Show what fighters are left
                    Console.WriteLine("\nHere are the fighters left on each team:");
                    Console.WriteLine("\nTeam A Fighters:");
                    DisplayFighters(choices, teamAFighters);

                    Console.WriteLine("\nTeam B Fighters:");
                    DisplayFighters(choices, teamBFighters);

                    


                    // Tell the who is fighting who
                    Console.WriteLine($"\n{fighter1.GetName()} from Team A will fight {fighter2.GetName()}" +
                        $" from Team B!");

                    // take a pause
                    Console.WriteLine("\n(Ready for battle?\nHit enter to continue.)");
                    Console.ReadLine();


                    // Find out player 1's weapon
                    Console.WriteLine("\nPlayer 1, choose a weapon for your fighter!");
                    //Console.WriteLine("Player 2, look away from the keyboard.");

                    // show their weapons and have one selected
                    ChooseWeapon(choices, fighter1, teamAWeapons);

                    // now for player 2
                    Console.WriteLine("\n\nPlayer 2, it's your turn!");
                    //Console.WriteLine("Player 1, look away from the keyboard.");

                    // show their weapons and have one selected
                    ChooseWeapon(choices, fighter2, teamBWeapons);

                    // now the battle begins
                    Console.WriteLine("\nThe battle begins!\n");
                    DetermineOutcome(fighter1, fighter2, teamAFighters, teamBFighters);


                }

                // one team must now be out of fighters
                // figure out who the winner is
                if (teamAFighters.Count > 0)
                {
                    Console.WriteLine($"\nTeam B is out of fighters.");
                    Console.WriteLine($"Player 1 is the winner!");
                }
                else if (teamBFighters.Count > 0)
                {
                    Console.WriteLine($"\nTeam A is out of fighters.");
                    Console.WriteLine($"Player A is the winner!");
                }
                else // otherwise it's a tie
                {
                    Console.WriteLine($"\nBoth teams are out of fighters.");
                    Console.WriteLine($"There is no winner!");
                }

                // find out if the players want to play another round
                Console.WriteLine("\nPlay another round?");
                // if they type something with the letter n in it, break. Otherwise, play again
                cont = Console.ReadLine().ToUpper();
                if (cont.Contains("N"))
                {
                    break;
                }


            }


        }

        // choose a weapon for a fighter
        public static void ChooseWeapon(string[] choices, Fighter fighter, List<string> weapons)
        {
            // Variables
            string weapon = "";
            int weaponNum;
            bool validEntry = false;

            // Get the weapon
            Console.WriteLine("\nHere are your weapons to choose from:");
            // Display list of weapons left to choose from
            DisplayWeapons(choices, weapons);

            // loop until they enter a letter
            while (String.IsNullOrEmpty(weapon) || !validEntry) // check validity
            {
                weapon = "";
                Console.WriteLine($"\nEnter the letter of {fighter.GetName()}'s weapon: ");
                // keep input private
                while (true)
                {
                    int x = Console.CursorLeft; // position of cursor
                    int y = Console.CursorTop;

                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter) // if the hit enter, break the loop
                    {
                        break;
                    } else if (key.Key == ConsoleKey.Backspace && weapon.Length > 0 
                        && Console.CursorLeft != 0) // for backspace - only do this if it's not at beginning
                    {

                        Console.SetCursorPosition(x - 1, y); 
                        weapon = weapon.Remove(weapon.Length - 1, 1); // remove letter from entry
                        Console.Write(" ");
                        Console.SetCursorPosition(x - 1, y);
                        

                    } else if (key.Key != ConsoleKey.Backspace)
                    {
                        Console.Write("*");
                        weapon += key.KeyChar;
                    }

                    // trim weapon just in case
                    weapon = weapon.Trim();

                }

                
                

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
                    } else if (String.IsNullOrEmpty(weapon) || String.IsNullOrWhiteSpace(weapon))
                    {
                        validEntry = false;
                        break;
                    }
                }
                // if it's invalid, let them know
                if (!validEntry)
                {
                    Console.WriteLine("\nInvalid entry.");
                }
            }

            // test
            //Console.WriteLine(weaponNum);

            // NO LONGER DO THIS - DOES NOT WORK PROPERLY THIS WAY - delete that weapon from list of weapons
            //weapons.RemoveAt(weaponNum); // if it stays -1, there's an error

            // set that weapon to the fighter's weapon
            fighter.SetWeapon(weapon);
        }



        // display and get the outcome of a battle
        public static void DetermineOutcome(Fighter fighter1, Fighter fighter2, // int index1, int index2,
            List<Fighter> TeamA, List<Fighter> TeamB)
        {
            // variables
            int outcome = fighter1.GetOutcome(fighter2); // find out the outcome depending on their weapons

            // tell what the weapons
            Console.WriteLine($"\n{fighter1.GetName()} fights with a {fighter1.GetWeapon()}," +
                $" {fighter2.GetName()} attacks with a {fighter2.GetWeapon()}!");

            // take action depending on the outcome
            if (outcome == 0) // if it's a tie
            {
                // tell players the outcome
                Console.WriteLine("They have both met their match! The fighters battle to the death, nobody wins.");
                // remove fighters from both lists
                TeamA.Remove(fighter1);
                TeamB.Remove(fighter2);
            } else if (outcome == 1) // if fighter 1 wins
            {
                // tell players the outcome
                Console.WriteLine($"The {fighter2.GetWeapon()} is no match for the {fighter1.GetWeapon()}. " +
                    $"{fighter1.GetName()} wins, {fighter2.GetName()} dies!");
                // remove the losing fighter
                TeamB.Remove(fighter2);
            } else // otherwise the outcome must be 2 - fighter 2 wins
            {
                // tell players the outcome
                Console.WriteLine($"The {fighter1.GetWeapon()} is no match for the {fighter2.GetWeapon()}. " +
                    $"{fighter2.GetName()} wins, {fighter1.GetName()} dies!");
                // remove the losing fighter
                TeamA.Remove(fighter1);
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
        public static void DisplayFighters(string[] choices, List<Fighter> fighters)
        {
            for(int i = 0; i < fighters.Count; i++) //this will only show fighters left on team
            {
                Console.WriteLine($"{choices[i]}. {fighters[i].GetName()}");
            }
        }

    }



}
