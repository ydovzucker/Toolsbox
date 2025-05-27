using System;

class Weapon
{
    public string name;
    public string make;
    public int AmountOfBullets;
    public Weapon(string name, string make,int AmountOfBullets )
    {
        this.name = name;
        this.make = make;
        this.AmountOfBullets = AmountOfBullets;

    }
    public void Shoot()
    {
        Console.WriteLine("Firieing a bullet");
        AmountOfBullets -= 1;
    }

}