using MarsRover;
using Xunit;

namespace MarsRoverTest
{
    public class RoverTests
    {
        [Fact]
        public void TestTurnLeft()
        {
            //Arrange
            Rover rover = new Rover("1 2 E", "5 5");
            //Act
            rover.TurnLeft();
            //Assert
            Assert.Equal("N", rover.direction);
        }

        [Fact]
        public void TestTurnRight()
        {
            //Arrange
            Rover rover = new Rover("1 2 E", "5 5");
            //Act
            rover.TurnRight();
            //Assert
            Assert.Equal("S", rover.direction);
        }

        [Fact]
        public void TestMoveForward()
        {
            //Arrange
            Rover rover = new Rover("1 2 E", "5 5");
            //Act
            rover.MoveForward();
            //Assert
            Assert.Equal(2, rover.x);
        }

        [Fact]
        public void TestGoToLocation()
        {
            //Arrange
            Rover rover = new Rover("1 2 N", "5 5");
            //Act
            rover.GoToLocation("LMLMLMLMM");
            //Assert
            Assert.Equal("1 3 N", rover.x + " " + rover.y + " " + rover.direction);
        }
    }
}