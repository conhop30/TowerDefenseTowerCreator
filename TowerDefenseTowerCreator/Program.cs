namespace Program
{
    public class Program
    {
        // Driver of the program.
        static void Main(string[] args)
        {
            // Declare variables.
            Tower tower = new Tower();
            CollectTowerData data = new CollectTowerData();
            Display display = new Display();

            // Generate a new tower.
            Tower completedTower = data.generateTower();

            // Display the new tower.
            display.displayTower(completedTower);

            return;
        }
    }
}