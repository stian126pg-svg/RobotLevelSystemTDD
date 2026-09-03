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
}