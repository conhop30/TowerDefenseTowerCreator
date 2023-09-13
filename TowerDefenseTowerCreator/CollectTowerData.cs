using System;

public class CollectTowerData
{
    private string inputAttackRange()
    {
        Console.Write("How far away can this Tower attack (Close, Medium, Far): ");
        string inputAttackRange = Console.ReadLine() ?? "";

        return inputAttackRange;
    }

    private string inputAttackSpeed()
    {
        Console.Write("How fast can this Tower attack (Slow, Medium, Fast): ");
        string inputAttackSpeed = Console.ReadLine() ?? "";

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
        int inputPowerDescription = Convert.ToInt32(temp);

        return inputPowerDescription;
    }
}
