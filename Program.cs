using System;

// Adding these here to cover the various variants of yes and no,
// so that we have an easier way to check through them each time the player answers.
string[] affirmatives = ["yes", "Yes", "Yeah", "yeah", "Sure", "sure", "y", "Y"];
string[] negatives = ["no", "No", "n", "N", "Nope", "nope", "no thanks", "No thanks", "nah", "Nah"];

// Create the player with a placeholder name that will be replaced later when we ask them for their name.
Player player = new Player("Placeholder", 10, true, [], []);

Cave firstCave = new Cave("Unknown Cave", "An eery cave that's damp and smells like rotten eggs.", false);

Mountain firstMountain = new Mountain("Unknown Mountain", "When you hear the word \"mountain,\" you tend to think of something pretty tall, but this one was surprisingly short!", false);

Beach firstBeach = new Beach("Unknown Beach","One look at this beach, with all the nice, warm sand and the soothing sound of the waves, and for moment you think to yourself that it might not be so bad to be stranded here for the rest of your life.", false);

// The initial startup dialogue.
Console.WriteLine("Greetings! Ready to go on an adventure?");
Console.WriteLine("Note: You can write \"yes\" / \"no\" or \"y\" / \"n\" to respond to yes/no questions in this game.");
Console.WriteLine("Other responses may lead to undesired results.");
string toPlayOrNotToPlay = Console.ReadLine();
if (negatives.Contains(toPlayOrNotToPlay)) 
{
    Console.WriteLine("Bye then!");
}
else if (affirmatives.Contains(toPlayOrNotToPlay))
{
    Console.WriteLine("Good luck! You're gonna need it...");
    while (player.IsAlive())
    {
        firstCave.DisplayAreaInfo();
        firstCave.DisplayScenario();
        int caveChoice = firstCave.PlayerChoice();
        if (caveChoice == 1)
        {
            firstBeach.DisplayAreaInfo();
            firstBeach.DisplayScenario();
            int beachChoice = firstBeach.PlayerChoice();
            if (beachChoice == 1)
            {
                firstMountain.DisplayAreaInfo();
                firstMountain.DisplayScenario();
                int mtnChoice = firstMountain.PlayerChoice();
                if (mtnChoice == 1)
                {
                    Console.WriteLine("You win! Huzzah!");
                    player.SetStatus(false);
                }
                else
                {
                    Console.WriteLine("You didn't make it off the island...");
                    player.SetStatus(false);                    
                }
            }
            else
            {
            Console.WriteLine("You didn't make it off the island...");
            player.SetStatus(false);                
            }
        }
        else
        {
            Console.WriteLine("You didn't make it off the island...");
            player.SetStatus(false);
        }
    }
}
else {
    Console.WriteLine("Not the type to answer a simple yes or no, eh? Or perhaps you don't like making choices, in which case this may not be the game for you. No hard feelings! You take care of yourself.");
}

