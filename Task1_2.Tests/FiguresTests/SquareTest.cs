using System.Collections.Generic;
using Task1_2.Figures;
using Xunit;

namespace Task1_2.Tests
{
    public class SquareTest
    {
        [Fact]
        public void GetArea_7_49Returned()
        {
            // arrange
            var figureType = "Square";
            var parties = new List<double>() { 7 };
            var square = new Square(figureType, parties);
            double expected = 49;

            // act
            double actual = square.GetArea();

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPerimeter_7and7and7and7_24Point42Returned()
        {
            // arrange
            var figureType = "Square";
            var parties = new List<double>() { 7, 7, 7, 7 };
            var square = new Square(figureType, parties);
            double expected = 28;

            // act
            double actual = square.GetPerimeter();

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Equelse_5and7_TrueReturned()
        {
            // arrange
            var figureType = "Square";
            var parties = new List<double>() { 7 };
            var square = new Square(figureType, parties);
            bool expected = true;

            // act

            bool actual = square.Equals(new Square(figureType, parties));

            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
