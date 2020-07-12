using System.Collections.Generic;
using Task1_2.Figures;
using Xunit;

namespace Task1_2.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void GetArea_6and8and10_24Returned()
        {
            // arrange
            var figureType = "Triangle";
            var parties = new List<double>() { 6, 8, 10 };
            var triangle = new Triangle(figureType, parties);
            double expected = 24;

            // act
            double actual = triangle.GetArea();

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPerimeter_6and8and10_24Point42Returned()
        {
            // arrange
            var figureType = "Triangle";
            var parties = new List<double>() { 6, 8, 10 };
            var triangle = new Triangle(figureType, parties);
            double expected = 24;

            // act
            double actual = triangle.GetPerimeter();

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Equelse_5and7_TrueReturned()
        {
            // arrange
            var figureType = "Triangle";
            var parties = new List<double>() { 6, 8, 10 };
            var triangle = new Triangle(figureType, parties);
            bool expected = true;

            // act

            bool actual = triangle.Equals(new Triangle(figureType, parties));

            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
