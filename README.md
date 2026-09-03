# Robot Level System TDD

A small XP and level system developed through test-driven development with C# and xUnit.

This project is the minimum viable product for the first TDD assignment in Module 3 of the backend development course.

## MVP

The system supports one core flow:

1. A robot operator awards experience points to a robot.
2. The robot's experience is updated.
3. The robot remains at its current level if it has insufficient experience.
4. The robot increases its level after earning enough experience.

A new robot starts at level 1, and 100 experience points are required to level up.

## Tested Behaviour

The test suite verifies that:

- A new robot starts at level 1.
- Awarding experience increases its experience points.
- Earning 100 experience points increases its level.
- Earning fewer than 100 experience points keeps its current level.

The project intentionally contains only four tests to remain within the assignment's MVP scope.

## Project Structure

```text
RobotLevelSystemTDD/
├── Excalidraw/
│   └── Robot Level System – MVP Flow.png
├── RobotLevelSystem/
│   ├── Robot.cs
│   └── RobotLevelSystem.csproj
├── RobotLevelSystem.Tests/
│   ├── RobotTests.cs
│   └── RobotLevelSystem.Tests.csproj
├── RobotLevelSystemTDD.slnx
└── README.md