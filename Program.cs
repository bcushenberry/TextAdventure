string[] affirmatives = ["yes", "Yes", "Yeah", "yeah", "Sure", "sure", "y", "Y"];
string[] negatives = ["no", "No", "n", "N", "Nope", "nope", "no thanks", "No thanks", "nah", "Nah"];

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
    Console.WriteLine("Good on you!");
}
else {
    Console.WriteLine("Not the type to answer a simple yes or no, eh? Or perhaps you don't like making choices, in which case this may not be the game for you. No hard feelings! You take care of yourself.");
}