using System;

class Player : Character
{
    // The inventory is pretty self-explanatory, but for now it is going to be used simply
    // My current idea is to present the player with a couple items to pick up, and depending on what item they choose, they'll either deal more damage or take less damage from attacks
    private string[] _inventory;

    // This is meant to be a tracker of all the choices the player makes, so that we can easily check later if they made a certain choice, and perhaps at the end we can give them a recap of their exploits (either when they die to some hazard or when they beat the game)
    private int[] _choices;
 
    public Player(string name, int health, bool isAlive, string[] inventory, int[] choices) : base(name, health, isAlive)
    {
        _inventory = inventory;
        _choices = choices;
    }

    public override bool IsAlive()
    {
        return _isAlive;
    }

    public void SetStatus(bool yn)
    {
        _isAlive = yn;
    }

    public string[] GetInventory()
    {
/*      
        I originally thought of making the inventory a hash set, and still might do it, but it seemed easier for now to just make it a string[]. Leaving the code here to remind myself to look into the possibility/benefits of using a hash set.

        HashSet<string> inventory = new HashSet<string>();
        foreach (string item in _inventory)
        {
            inventory.Add(item);
        }
*/
        return _inventory;
    }
}