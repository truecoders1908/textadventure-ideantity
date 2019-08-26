using System;


namespace Enigma
{
    class Program
    {
        private static string key;

        static void Main(string[] args)
        {
            Console.Title = "The Enigma of the fault";
            var title = new[]
            {
               @"   ______      _                                ____  ",
               @"  / ____/___  (_)___ _____ ___  ____ _   ____  / __/  ",
               @" / __/ / __ \/ / __ `/ __ `__ \/ __ `/  / __ \/ /_    ",
               @"/ /___/ / / / / /_/ / / / / / / /_/ /  / /_/ / __/     ",
              @"/_____/__ /_/_/\__, /_____/ /_/\__,_/________/_/       ",
              @"  / /_/ /_  __/____// __/___ ___  __/ / /_            ",
              @" / __/ __ \/ _ \   / /_/ __ `/ / / / / __/            ",
              @"/ /_/ / / /  __/  / __/ /_/ / /_/ / / /_              ",
              @"\__/_/ /_/\___/  /_/  \__,_/\__,_/_/\__/              ",
                // Credit -- Author: Junji ito 10/10 would reccomend
                // Have book if intrested in reading 

            };
            Console.WriteLine("\n\n");
            foreach (string line in title)
                Console.WriteLine(line);
            Console.ReadKey();



            string charactername;
            string town;
            string friend;
            string man = "Owaki";
            System.Console.Write("\nEnter your character name: ");
            charactername = Console.ReadLine();
            System.Console.Write("\nWhere are you from?: ");
            town = Console.ReadLine();
            Console.WriteLine("\nSo {0} you're from {1}?", charactername, town);
            Console.WriteLine("\n{0} recently went through an earthquake revealing a fault thats been all over\n the news people all from {0} have traveled to come see it", town);
            System.Console.Write("\nAs {0} travels to the fault they meet someone also traveling to the fault\n\nnamed:", charactername);
            friend = Console.ReadLine();
            Console.WriteLine("\n{0} and {1} finally have made it to the fault\nimmeditly feeling an errie sense that something was wrong", charactername, friend);
            Console.ReadKey(); //press a key to continue story
            Console.WriteLine("\n{0} notices holes that appear to look like silhouettes of people. \none of the townsman named {1} became manic\nand saw a hole that resembles {1} silhouette", friend, man);
            Console.ReadKey();
            Console.WriteLine("\n{0} Screams out THIS IS MY HOLE I HAVE TO ENTER IT, IT'S ITS CALLING MY NAME", man);
            Console.ReadKey();
            Console.WriteLine("\n{0} Slowly goes through the hole shaped silhouette\nsoon to show no trace of him afterwards\nrescue teams came in to search for {0} but couldnt see any trace of him", man);
            Console.ReadKey();
            Console.WriteLine("\n{0} finds a hole that resembles {0} suddenly feeling a strong urge to enter {0}'s hole.\n{1} convinces {0} not to go in and cover the hole with rocks", friend, charactername);
            Console.ReadKey();
            Console.WriteLine("\n{1} wakes up from a nightmare to find {0} gone {1} runs out of the tent\nfinding {0}'s hole has been uncovered {0} is no where to be found", friend, charactername);
            Console.ReadKey();
            Console.WriteLine("\n{0} then finds a hole that resembles {0}'s\n\nshould {0} enter???", charactername);
            Console.ReadKey();
            System.Console.Write("\n[y/n]:");
            key = Console.ReadLine();
            if (key == "y")
            {
                Console.WriteLine("\n{0} slowly enters hole only to find it slowly stretching {0} body\nunable to walk back out", charactername);
                Console.ReadKey();
                Console.WriteLine("\n{0} thinks the hole is endless {0}\nfeels that {0}'s body is being slowly disfigured", charactername);
                Console.ReadKey();
                Console.WriteLine("\nRescue teams find out theres another side to the fault and find oddly shaped \nholes and look through to only find deformed 'creatures' \nfrom then holes people have entered through");

            }
            else if (key == "n")
            {
                Console.WriteLine("End");
                return;
            }

        }

    }
}