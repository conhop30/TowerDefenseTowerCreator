using System;

public class Tower
{
    // Initialize variables.
    int attackRange = 0;
    int attackSpeed = 0;
    string powerDescription = "defaultPowerDescription"; 
    int powerMaximum = 1;

    // Getters and setters.
    public int getAttackRange() { return attackRange; }
    public void setAttackRange(int newAttackRange) { this.attackRange = newAttackRange; }

    public int getAttackSpeed() {  return attackSpeed; }
    public void setAttackSpeed(int newAttackSpeed) { this.attackSpeed = newAttackSpeed; }

    public string getPowerDescription() { return powerDescription; }
    public void setPowerDescription(string newPowerDescription) { this.powerDescription = newPowerDescription; }

    public int getPowerMaximum() { return powerMaximum; }
    public void setPowerMaximum(int newPowerMaximum) { this.powerMaximum = newPowerMaximum; }
}
