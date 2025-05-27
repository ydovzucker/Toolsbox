using System;
using System.Xml.Linq;

class AirCommando:Commando
{
    public AirCommando(string name, string codeName): base( name, codeName)
    {

    }
    public void Parachuting()
    {
        Console.WriteLine("Soldier is currently parachuting..");
    }
    public override void Attack()
    {
        Console.WriteLine($"Air Commando Soldier  attacking ");
    }
}