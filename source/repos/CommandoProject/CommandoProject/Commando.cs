using System;
using System.Collections.Generic;

class Commando
{

    private  string _name;
    public  string _codeName { get; set; }
    public string[] _tools = { "hammer", "chisel", "rope", "bag", "canteen" };
    public string status = "standing";
    //public Weapon weapon;


    public Commando(string name,string codeName)
    {
        this._name = name;
        this._codeName = codeName;
        //this._tools = tools;
        this.status = status;
    }
    public void Walk()
    {
        Console.WriteLine("soldier walking");
        this.status = "walking";
        
    }
    public void Hiding()
    {
        Console.WriteLine("soldier hiding");
        this.status = "hiding";

    }
    public void SayName (string commanderRank)
    {
        if (commanderRank == "GENERAL")
        {
            Console.WriteLine(this._name);
        }
        else if (commanderRank == "COLONEL")
        {
            Console.WriteLine(this._codeName);
        }
        else
        {
            Console.WriteLine("This is classified information, you do not have access to it.");
        }
    }

    public  virtual void  Attack()
    {
        Console.WriteLine($"regullar soldier commando attacking ");
    }
}