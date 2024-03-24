using System;

class Beach : Area
{
    public Beach(string name, string description, bool visited) : base(name, description, visited)
    {

    }

    public override void GoLeft()
    {
        Console.WriteLine("You cannot go that way");
    }

    public override void GoRight()
    {
        Console.WriteLine("You cannot go that way");    
    }

    public override void GoForward()
    {
        Console.WriteLine("You cannot go that way");
    }

    public override void GoBack()
    {
        Console.WriteLine("You cannot go that way");
    }

    public override void DisplayAreaInfo()
    {
        Console.WriteLine($"{_name}\n{_description}");
    }

    public override void DisplayScenario()
    {
        Console.WriteLine($"There's some crazy stuff happening on this beach! Also, you see a boat that you can sail out to sea with, or a bunch of rocks that could use to try and signal someone flying overhead.");
    }    

    public override int PlayerChoice()
    {
        Console.WriteLine("What do you do?");
        Console.WriteLine("1. Move forward");
        Console.WriteLine("2. Stay here.");
        int beachChoice = int.Parse(Console.ReadLine());

        if (beachChoice == 1)
        {
            Console.WriteLine("Good Choice!");
        }
        else if (beachChoice == 2)
        {
            Console.WriteLine("The grues are out, and they got you!");
            Console.WriteLine("Thanks for playing");
        }
        else
        {
            Console.WriteLine("Please choose either 1 or 2.");
        }

        return beachChoice;
    }

}