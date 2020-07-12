using System.Collections.Generic;
using Task1_2.Figures;
using Task1_2.Figures.Interfaces;
using Task1_2.FiguresExtensions;
using Xunit;

namespace Task1_2.Tests
{
    public class ParseFigureTest
    {
        [Fact]
        public void GetFiguresTest()
        {
            // arrange
            var figureType = "Triangle";
            var parties = new List<double>() { 6, 8, 10 };
            var expected = new IFigure[1];
            expected[0] = new Triangle(figureType, parties);

            // act
            var actual = ParseFigure.GetFigures(@"..\..\..\Resurses\1Figures.txt");

            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
