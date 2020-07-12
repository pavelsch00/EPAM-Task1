using System.Collections.Generic;
using Task1_2.Figures;
using Xunit;

namespace Task1_2.Tests
{
    public class RectangleTest
    {
        [Fact]
        public void GetArea_5and5_35Returned()
        {
            // arrange
            var figureType = "Rectangle";
            var parties = new List<double>() { 5, 7 };
            var rectangle = new Rectangle(figureType, parties);
            double expected = 35;

            // act
            double actual = rectangle.GetArea();

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPerimeter_5and7_24Point42Returned()
        {
            // arrange
            var figureType = "Rectangle";
            var parties = new List<double>() { 5, 7 };
            var rectangle = new Rectangle(figureType, parties);
            double expected = 24;

            // act
            double actual = rectangle.GetPerimeter();

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Equelse_5and7_TrueReturned()
        {
            // arrange
            var figureType = "Rectangle";
            var parties = new List<double>() { 5, 7 };
            var rectangle = new Rectangle(figureType, parties);
            bool expected = true;

            // act

            bool actual = rectangle.Equals(new Rectangle(figureType, parties));

            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
