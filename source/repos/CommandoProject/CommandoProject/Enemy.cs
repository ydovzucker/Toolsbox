using System;

public class Enemy
{
    private string _name { get; set; }
    public  int _life = 100;
    public bool _isAlive = true;

    public Enemy(string name)
    {
        this._name = name;

    }
    public void scream()
    {
        Console.WriteLine("i am a enemy");
    }
}