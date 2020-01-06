using System;

namespace WillowWoodsPreCode
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayDoorChallenge();
        }
        public static void DisplayMonsterChallenge()
        {
            int userEntry;
            int userHits = 0;
            int min = 1;
            int max = 2;
            int chance;
            Random ranNumberGenerator = new Random();
            chance = ranNumberGenerator.Next(min, max);

            Console.WriteLine("Oh no you encountered a monster! You can't get past it and you can't go back or get away, you must fight!" +
                " Click hit to hit the monster");
            // next button would be placed
            userEntry = Convert.ToInt32(Console.ReadLine());
            userHits = userHits + 1;
            // when transferring to form, don't worry about user input since you are using a button

            do
            {
                if (userEntry == chance)
                {             
                    Console.WriteLine("You hit it! It looks like its wearing down. Try hitting it again to defeat it!");
                    userEntry = Convert.ToInt32(Console.ReadLine());
                    userHits = userHits + 1;

                    if (userEntry == chance)
                    {
                        Console.WriteLine("Wow you defeated the monster! Guess you are pretty strong!");
                        userHits = userHits + 1;
                        DisplayDoorChallenge();
                        // In form would change panel 
                    }

                    
                }
                else
                {
                    Console.WriteLine("You missed, try again!");
                    userEntry = Convert.ToInt32(Console.ReadLine());       

                    if (userEntry == chance)
                    {
                        Console.WriteLine("You defeated the monster! Whew that was close!");
                        userHits = userHits + 1;
                        DisplayDoorChallenge();      
                        // In form would change panel 
                    }

                }

            } while (userHits != 2);
            


        }
        public static void DisplayDoorChallenge()
        { 
            int userEntry;
            int choice;
            Random ranNumberGenerator = new Random();
            choice = ranNumberGenerator.Next(1, 2);

            Console.WriteLine("Looks like you're almost close to the exit! Now pick a door but be warned a monster may be waiting behind one. Choose wisely");
            userEntry = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (userEntry == choice)
                {
                    Console.WriteLine("Yay you chose the right door! You're now free!");
                    Console.WriteLine("--------------------------------------------------------------------");
                    DisplayGameEnd();
                    // In form would change panel 
                }
                else
                {       
                    DisplayMonsterChallenge();
                    
                    // In form would change panel 
                }

            } while (userEntry != choice);
            
        }
        public static void DisplayGameEnd()
        {
            Console.WriteLine("*You finally see daylight and run in joy*" + 
            "\nYou: Finally! I’m free, I’m free, I’m free!" + "\nLune: Wow that was quite the adventure!" +
            "\nYou: Yea that was crazy, I thought I was going to die at some point." +
            "\nLune: Well now you're free...so I guess you won't have to worry about that." + "\nYou: Yea..." +  
            "\n*You look back at Lune who is standing on the edge of Willow Woods and the daylight. You walk back to her and say*" +
            "\nYou: I guess this is goodbye… Thank you for all the help Lune, I won’t have made it out alive if it weren’t for you." +
            "\nLune: I do my best…" + "\n*An awkward silence settles in. You slowly start to back away and turn you’re back to Lune." +
            " With one hand raised, you wave goodbye and walk away. A small voice echos in you’re head.*" +
            "\n???: Come back to visit!" + "\n*You turn around and catch a glimpse of what looks like a girl waving before it disappeared in the fog.*" +
            "\nThen it clicked, Lune was Willow." + "\nThe End");
        }
    }
}

