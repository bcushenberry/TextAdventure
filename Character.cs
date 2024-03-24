using System;

abstract class Character
{
    protected string _name;
    protected int _health;
    protected bool _isAlive;

    public Character(string name, int health, bool isAlive = true)
    {
        _name = name;
        _health = health;
        _isAlive = isAlive;
    }

    public abstract bool IsAlive();
}