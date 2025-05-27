using System;

class SeaCommando:Commando
{
    public SeaCommando(string name, string codeName) : base(name, codeName)
    {

    }
    public void Swimming()
    {
        Console.WriteLine("Soldier is now swimming.");
    }
    public override void Attack()
    {
        Console.WriteLine("Naval Commando Soldier attacking");
    }
}