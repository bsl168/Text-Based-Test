using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

    //Adventure Game

    public static class Game
        {
        //character name and introduction
        static string CharacterName = "John Doe";

        //Game Title
    public static void StartGame()
            {
                Console.WriteLine("Adventure!\n\n");
                Console.WriteLine("This is strictly for educational purposes");
            
                Console.WriteLine("It is the end of summer, you hear the cicadas chirping as you get out of your taxi.\n");
                Console.WriteLine("Before you stands an old decrepit old house. The roof seems to be poorly maintained.\n");
                Console.WriteLine("\"I'm really not sure why you are here errrr...\" says the cab driver who seems to be at a loss with what to call you");

            }

        public static void NameChar()
        {
            Console.WriteLine("You're probably never going to meet him again, but it's rude to not introduce yourself\n\n");

            //input character name and print introduction - insert validation of names later. Ignore for now.
            CharacterName = Console.ReadLine();
            Console.WriteLine("");
        }

            public static void StartAdventure() //Actual choices start here

            {
              

                Console.WriteLine($"The cab driver gives you a look like this is completely pointless \"Goodluck {CharacterName}! we're never meeting again.\"\n\n ");
                Console.WriteLine("You stare as the taxi drives off, leaving you alone with the house. \nYou don't know what his problem is but you're never meeting them again");
                Console.WriteLine("There doesn't seem to be anything else nearby except for a mailbox\n\n");
                Console.WriteLine(" \"Hmmm...\" you think to yourself.\n");
                Console.WriteLine("What next?\n");
                
            }

        }
    class Item
        {
        }
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Game.NameChar();
            Game.StartAdventure();
            Console.ReadKey();

        }
    }
}
