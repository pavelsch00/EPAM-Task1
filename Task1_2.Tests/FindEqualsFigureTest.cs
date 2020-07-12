using System.Collections.Generic;
using Task1_2.Figures;
using Task1_2.FiguresExtensions;
using Xunit;

namespace Task1_2.Tests
{
    public class FindEqualsFigureTest
    {
        [Fact]
        public void FindEqualsFiguresTest()
        {
            // arrange
            var temp = ParseFigure.GetFirus(@"..\..\..\Figures.txt");
            var figureType = "Square";
            var parties = new List<double>() { 7 };
            var square = new Square(figureType, parties);
            var expected = square;

            // act
            var actual = FindEqualsFigure.FindEqualsFigures(square, temp)[0];

            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
