namespace RobotLevelSystem;

public class Robot
{
    private const int ExperienceRequiredToLevelUp = 100;

    public int Level { get; private set; } = 1;

    public int ExperiencePoints { get; private set; }

    public void AddExperience(int amount)
    {
        ExperiencePoints += amount;

        if (ExperiencePoints >= ExperienceRequiredToLevelUp)
        {
            Level++;
        }
    }
}