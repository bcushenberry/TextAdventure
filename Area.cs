using System;

abstract class Area
{
    protected string _name;
    protected string _description;

    // This isn't really being used yet, but I thought it would be helpful to have this information so we could alter what text is displayed depending on whether the player has been to the area or not.
    protected bool _visited;


    public Area(string name, string description, bool visited)
    {
        _name = name;
        _description = description;
        _visited = visited;

    }

// Currently these aren't used at all, but I thought they would be very useful in a further developed version of this, where each room would have multiple ways to go.
    public abstract void GoLeft();
    public abstract void GoRight();
    public abstract void GoForward();
    public abstract void GoBack();

// This isn't the most elegant way to do it, but I figured a room can be divided into three parts: The description of the room itself, the "scenario" or events that happen in the room, and the player's choice. In a more complicated version of this game, the player would be able to go back and forth between rooms, in which case we could check to see if the player had already been to the room using the "visited" varaible, and then display different info.

    public abstract void DisplayAreaInfo();
    public abstract void DisplayScenario();
    public abstract int PlayerChoice();
}