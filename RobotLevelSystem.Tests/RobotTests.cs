using RobotLevelSystem;
using Xunit;

namespace RobotLevelSystem.Tests;

public class RobotTests
{
    [Fact]
    public void NewRobot_StartsAtLevelOne()
    {
        // Arrange
        var robot = new Robot();

        // Act
        var level = robot.Level;

        // Assert
        Assert.Equal(1, level);
    }

    [Fact]
    public void AddExperience_IncreasesExperiencePoints()
    {
        // Arrange
        var robot = new Robot();

        // Act
        robot.AddExperience(40);

        // Assert
        Assert.Equal(40, robot.ExperiencePoints);
    }
}