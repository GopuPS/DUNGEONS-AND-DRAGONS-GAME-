using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dungeons and Dragons Word Game!\n");

            Console.WriteLine("Are you ready to embark on a journey through Arandor? (Y/N)");
            string decision = Console.ReadLine().ToUpper();

            if (decision == "Y")
            {
                
                Console.WriteLine("\nGreat! Let's get started.\n");

                bool gameOver = false;
                int round = 1;
                bool gameWon = false;

                while (!gameOver && round <= 3 && !gameWon)
                {
                    switch (round)
                    {
                        case 1:
                            Console.WriteLine("ROUND 1: PUZZLE");
                            Console.WriteLine("You have entered a dark dungeon. In order to proceed, you must solve a puzzle.");
                            Console.WriteLine("The puzzle is a word jumble. Unscramble the following letters to reveal a word:");
                            Console.WriteLine("SNOERAGADN\n");
                            string answer1 = Console.ReadLine().ToUpper();

                            if (answer1 == "DRAGONES")
                            {
                                Console.WriteLine("\nCongratulations! You have solved the puzzle and defeated the dragon that was guarding the exit.");
                                round++;
                            }
                            else
                            {
                                Console.WriteLine("\nYou failed to solve the puzzle and were devoured by the dragon. GAME OVER.");
                                gameOver = true;
                            }

                            break;

                        case 2:
                            Console.WriteLine("\nROUND 2: QUIZ");
                            Console.WriteLine("You have emerged from the dungeon and come across a group of wizards. They will allow you to pass only if you can answer their question.");
                            Console.WriteLine("Question: What is the name of the potent item with the capacity to restore light and drive away darkness in Arandor?");
                            Console.WriteLine("a) Sword of Light");
                            Console.WriteLine("b) Sunstone");
                            Console.WriteLine("c) Crystal of Radiance\n");
                            string answer2 = Console.ReadLine().ToUpper();

                            if (answer2 == "B")
                            {
                                Console.WriteLine("\nCongratulations! You have answered correctly and the wizards have granted you passage.");
                                round++;
                            }
                            else
                            {
                                Console.WriteLine("\nYou failed to answer correctly and were struck by a lightning bolt. GAME OVER.");
                                gameOver = true;
                            }
                    
                            break;
                        case 3:
    Console.WriteLine("\nROUND 3: QUEST");
    Console.WriteLine("You have arrived at the entrance to the cave where the darkness originated. You must complete a quest to gain access to the cave.");
    Console.WriteLine("Your quest is to retrieve the ancient artifact hidden in the nearby forest. Beware of the monsters that guard it.");
    Console.WriteLine("Are you ready to begin the quest? (Y/N)");
    string decision2 = Console.ReadLine().ToUpper();

    if (decision2 == "Y")
    {
        Console.WriteLine("\nYou enter the forest and come across a group of goblins. You must defeat them in battle to proceed.\n");

        int playerHealth = 100;
        int goblinHealth = 50;
        bool battleOver = false;

                        while (!battleOver)
                                {
                                    Console.WriteLine("Your health: " + playerHealth);
                                    Console.WriteLine("Goblin's health: " + goblinHealth);

                                    Console.WriteLine("\nWhat move do you want to make? (Sword / Fireball / Heal)");
                                    string move = Console.ReadLine().ToUpper();

                        switch (move)
                                {
                                    case "SWORD":
                                    Console.WriteLine("\nYou swing your sword and deal 20 damage to the goblin.");
                                    goblinHealth -= 20;
                                    break;

                                    case "FIREBALL":
                                    Console.WriteLine("\nYou cast a fireball and deal 30 damage to the goblin.");
                                    goblinHealth -= 30;
                                    break;

                                    case "HEAL":
                                    Console.WriteLine("\nYou focus your energy and heal yourself for 20 health points.");
                                    playerHealth += 20;
                                    break;

                                    default:
                                    Console.WriteLine("\nInvalid move. Please try again.");
                                    break;
                                
                                
                                }
                                
                                
            if (goblinHealth <= 0)
            {
                Console.WriteLine("\nCongratulations! You have defeated the goblins and retrieved the ancient artifact.\n");
                Console.WriteLine("You enter the cave and find the source of the darkness. After defeating the evil sorcerer, you restore the light to Arandor.");
                Console.WriteLine("YOU WIN!");
                battleOver = true;
                round++;
            }
            
            else if (playerHealth <= 0)
            {
                Console.WriteLine("\nYou have been defeated by the goblins. GAME OVER.");
                battleOver = true;
                gameOver = true;
            }
            

            // break out of while loop if game is over
            if (battleOver || gameOver)
            {
                break;
            }
            
                                }   
                                                             
    }
    else
    {
        Console.WriteLine("\nYou decide not to proceed with the quest and are unable to restore the light to Arandor. GAME OVER.");
        gameOver = true;
    }
                    
    break;
                    }
                
            }
            
        }
        
    }
    
}

}