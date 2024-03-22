using System.Runtime.CompilerServices;

public class Player
{
    private string _name;
    private int _health;
    private string[] _inventory; 

    public Player(string name, int health, string[] inventory)
    {
        _health = health;
        _name = name;
        _inventory = inventory;
    }

    public string[] /* HashSet<string> */ GetInventory()
    {
/*         HashSet<string> inventory = new HashSet<string>();
        foreach (string item in _inventory)
        {
            inventory.Add(item);
        } */
        return _inventory;
    }
}