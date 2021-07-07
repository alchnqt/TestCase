using System.Collections.Generic;
using TestCase.Basics;
using TestCase.Services.Contracts;
using TestCase.Services.Implementations;
using Xunit;

namespace TestCaseTests
{
    public class ServicesTest
    {
        private IStringValidatorService stringValidator = new CommandLineValidatorService();
        private IPointValidatorService pointValidator = new PointValidatorService();

        [Fact]
        public void ValidateString_InvalidInput_ReturnsFalse()
        {
            string invalidStr = "5v5 (0, 0) (1, 3) (4, 4) (4, 2) (4, 2) (0, 1) (3, 2) (2, 3) (4, 1)";
            Assert.False(stringValidator.ValidateString(invalidStr));
        }

        [Fact]
        public void ValidateString_ValidInput_ReturnsTrue()
        {
            string validStr = "5x5 (0, 0) (1, 3) (4, 4) (4, 2) (4, 2) (0, 1) (3, 2) (2, 3) (4, 1)";
            Assert.True(stringValidator.ValidateString(validStr));
        }

        [Fact]
        public void ValidatePointsInMap_PointsInMap_ReturnsTrue()
        {
            Map map = new Map(13, 13);
            List<Point> list = new() { new Point(12, 12), new Point(13, 13) };
            Assert.True(pointValidator.ValidatePointsInMap(map, list));
        }

        public void ValidatePointsInMap_PointOuttaMap_ReturnsFalse()
        {
            Map map = new Map(5, 5);
            List<Point> list = new() { new Point(1, 2), new Point(13, 13) };
            Assert.False(pointValidator.ValidatePointsInMap(map, list));
        }
    }
}
