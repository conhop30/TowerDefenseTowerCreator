using System;

public class Display
{
    public void displayTower()
    {
        Tower tower = new Tower();

        Console.WriteLine("Upon reaching " + tower.getPowerMaximum() + " power, your tower will do the following:");
        Console.WriteLine("\"" + tower.getPowerDescription() + "\"");
        Console.WriteLine("Attack Range: " + tower.getAttackRange());
        Console.WriteLine("Attack Speed: " + tower.getAttackSpeed());
    }
}
