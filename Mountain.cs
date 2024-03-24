using System;

class Mountain : Area
{
    public Mountain(string name, string description, bool visited) : base(name, description, visited)
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
        Console.WriteLine($"X and Y and Z are happening here. You also see A, B, and C.");
    }    

    public override int PlayerChoice()
    {
        Console.WriteLine("What do you do?");
        Console.WriteLine("1. Move forward");
        Console.WriteLine("2. Stay here.");
        int mtnChoice = int.Parse(Console.ReadLine());

        if (mtnChoice == 1)
        {
            Console.WriteLine("Good Choice!");
        }
        else if (mtnChoice == 2)
        {
            Console.WriteLine("The grues are out, and they got you!");
            Console.WriteLine("Thanks for playing");
        }
        else
        {
            Console.WriteLine("Please choose either 1 or 2.");
        }

        return mtnChoice;
    }

}