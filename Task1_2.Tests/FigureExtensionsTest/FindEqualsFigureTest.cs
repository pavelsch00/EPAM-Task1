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
            var figureType = "Square";
            var parties = new List<double>() { 7 };
            var expected = new Square(figureType, parties);

            // act
            var actual = FindEqualsFigure.FindEqualsFigures(expected, ParseFigure.GetFigures(@"..\..\..\Resurses\Figures.txt"))[0];

            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
