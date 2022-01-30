using MarsRoverTechChallenge.Services;
using Xunit;
namespace Assessment.Tests
{
    public class MarsRoverTest
    {
        [Theory]
        [InlineData("5 5", "1 2 N", "LMLMLMLMM", "1 3 N")]
        [InlineData("5 5", "3 3 E", "MMRMMRMRRM", "5 1 E")]
        [InlineData("5 5", "0 0 N", "MMMMMRMMMMM", "5 5 E")]
        public void MarsRover_Shoud_Be_In_The_Right_Final_Position(string plateauBounds, string initialLocationAndHeading, string instructions, string expectedFinalPositionAndHeading)
        {

            var plateau = new MarsPlateau(plateauBounds);
            var rover = new MarsRover(initialLocationAndHeading);
            plateau.SendRover(rover);
            var result = plateau.SendRoverInstructions(instructions);
            Assert.Equal(expectedFinalPositionAndHeading, result);
        }
    }
}
