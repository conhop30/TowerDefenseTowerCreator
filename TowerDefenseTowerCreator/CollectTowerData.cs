using System;

public class CollectTowerData
{
    private int inputAttackRange()
    {
        // Initialize the return value
        int inputAttackRange = 0;

        Console.Write("How far away can this Tower attack (Close, Medium, Far): ");
        string temp = Console.ReadLine() ?? "";

        // Convert string input into int value
        if (temp == "Medium" || temp == "medium")
        {
            inputAttackRange = 2;
        }
        else if (temp == "Far" || temp == "far")
        {
            inputAttackRange = 3;
        }
        // Must be "close"
        else
        {
            inputAttackRange = 1;
        }

        return inputAttackRange;
    }

    private int inputAttackSpeed()
    {
        // Initialize the return value
        int inputAttackSpeed = 0;

        Console.Write("How fast can this Tower attack (Slow, Medium, Fast): ");
        string temp = Console.ReadLine() ?? "";

        // Convert string input into int value
        if (temp == "Medium" || temp == "medium")
        {
            inputAttackSpeed = 20;
        }
        else if (temp == "Fast" || temp == "fast")
        {
            inputAttackSpeed = 30;
        }
        // Must be "Slow"
        else
        {
            inputAttackSpeed = 10;
        }

        return inputAttackSpeed;
    }

    private string inputPowerDescription()
    {
        Console.Write("What does the Tower do: ");
        string inputPowerDescription = Console.ReadLine() ?? "";

        return inputPowerDescription;
    }

    private int inputPowerMaximum()
    {
        Console.Write("How many attacks does this Tower need before using its power: ");
        string temp = Console.ReadLine() ?? "";
        int inputPowerDescription = Convert.ToInt16(temp);

        return inputPowerDescription;
    }

    public Tower generateTower()
    {
        Tower tower = new Tower();

        tower.setPowerDescription(inputPowerDescription());
        tower.setPowerMaximum(inputPowerMaximum());
        tower.setAttackRange(inputAttackRange());
        tower.setAttackSpeed(inputAttackSpeed());

        return tower;
    }
}
