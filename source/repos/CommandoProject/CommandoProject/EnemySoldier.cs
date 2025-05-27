public abstract class EnemySoldier
{
    string strongAgainstCommando { get; set; }
    string strongAgainstWeapon { get; set; }
    string weekAgainstSoldier { get; set; }
    string weekAgainstWeapon { get; set; }



    public  EnemySoldier(string strongAgainstCommando,string strongAgainstWeapon,string weekAgainstSoldier,string weekAgainstWeapon)
    {
        this.strongAgainstCommando = strongAgainstCommando;
        this.strongAgainstWeapon = strongAgainstWeapon;
        this.weekAgainstSoldier = weekAgainstSoldier;
        this.weekAgainstWeapon = weekAgainstWeapon;
    }


}
