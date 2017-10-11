using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

    //A Simple Program to display the words Hello World

    class Program
    {
        static void Main(string[] args)
        {
            string CharacterName = "John Doe";

            Console.WriteLine("Adventure!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("It is the end of summer, you hear the cicadas chirping as you get out of your taxi.");
            Console.WriteLine("Before you stands an old decrepit old house. The roof seems to be poorly maintained.");
            Console.WriteLine("\"I'm really not sure why you are here errrr...\" says the cab driver who seems to be at a loss with what to call you");
            Console.WriteLine("You're probably never going to meet him again, but it's rude to not introduce yourself");
            CharacterName = Console.ReadLine();
            Console.WriteLine("The cab driver gives you a look like this is completely pointless \"Goodluck " +CharacterName+ " we're never meeting again.\" ");
            Console.WriteLine("You stare as the taxi drives off, leaving you alone with the house. You don't know what his problem is but you're never meeting them again");
            Console.WriteLine("There doesn't seem to be anything else nearby except for a mailbox");
            Console.WriteLine("");
            Console.WriteLine(" \"Hmmm...\" you think to yourself.");
            Console.WriteLine("");
            Console.WriteLine("What next?");
            Console.Read();    
        }
    }
}
