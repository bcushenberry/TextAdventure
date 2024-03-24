using System;

class Enemy : Character
{
    public Enemy(string name, int health, bool isAlive) : base(name, health, isAlive)
    {
    }

    public override bool IsAlive()
    {
        return _isAlive;
    }
}