namespace RobotLevelSystem;

public class Robot
{
    public int Level { get; } = 1;

    public int ExperiencePoints { get; private set; }

    public void AddExperience(int amount)
    {
        ExperiencePoints += amount;
    }
}