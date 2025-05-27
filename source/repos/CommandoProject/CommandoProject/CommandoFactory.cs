using System;
using System.Collections.Generic;

class CommandoFactory
{
    public List<Commando> allCommando = new List<Commando>();

    public void AddCommando(string typeOfComando,string name,string codeName)
    {
        switch (typeOfComando)
        {
            case "Commando":
                Commando newCommando = new Commando(name, codeName);
                allCommando.Add(newCommando);
                break;
            case "SeaCommando":
                SeaCommando newSEaCommando = new SeaCommando(name, codeName);
                allCommando.Add(newSEaCommando);
                break;

            case "AirCommando":
                AirCommando newAircommando = new AirCommando(name, codeName);
                allCommando.Add(newAircommando);
                break;
            default:
                Console.WriteLine("not a valid Commando");
                break;

        } 



        

    }
}