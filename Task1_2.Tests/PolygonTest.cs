using System.Collections.Generic;
using Task1_2.Figures;
using Xunit;

namespace Task1_2.Tests
{
    public class PolygonTest
    {
        [Fact]
        public void GetArea_5and5_78pPoint53981633974483Returned()
        {
            // arrange
            string figureType = "Circle";
            List<double> parties = new List<double>() { 5, 5 };
            Circle circle = new Circle(figureType, parties);
            double expected = 78.53981633974483;

            // act
            double actual = circle.GetArea();

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPerimeter_5and5_31Point41592653589793Returned()
        {
            // arrange
            string figureType = "Circle";
            List<double> parties = new List<double>() { 5, 5 };
            Circle circle = new Circle(figureType, parties);
            double expected = 31.41592653589793;

            // act
            double actual = circle.GetPerimeter();

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Equelse_5and5_TrueReturned()
        {
            // arrange
            string figureType = "Circle";
            List<double> parties = new List<double>() { 5, 5 };
            Circle circle = new Circle(figureType, parties);
            bool expected = true;

            // act

            bool actual = circle.Equals(new Circle(figureType, parties));

            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
