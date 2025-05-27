using System.Collections.Generic;

public class EnemyFactory
{
    public List<Enemy> allEnemys = new List<Enemy>();
    public void AddEnemy(string name)
    {
        Enemy newEnemy = new Enemy(name);
        allEnemys.Add(newEnemy);

    }
}