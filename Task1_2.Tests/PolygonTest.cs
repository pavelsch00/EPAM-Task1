using System.Collections.Generic;
using Task1_2.Figures;
using Xunit;

namespace Task1_2.Tests
{
    public class PolygonTest
    {
        [Fact]
        public void GetArea_2Point8and9Point5and3Point2and6Point3_4Point5Returned()
        {
            // arrange
            var figureType = "Polygon";
            var parties = new List<double>() { 2.8, 9.5, 3.2, 6.3 };
            var points = new int[2, 4] { { 7, 5, 8, 5 }, { 9, 11, 2, 3 } };
            var polygon = new Polygon(figureType, parties, points);
            double expected = 4.5;

            // act
            double actual = polygon.GetArea();

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPerimeter_2Point8and9Point5and3Point2and6Point3_21Point8Returned()
        {
            // arrange
            var figureType = "Polygon";
            var parties = new List<double>() { 2.8, 9.5, 3.2, 6.3 };
            var points = new int[2, 4] { { 7, 5, 8, 5 }, { 9, 11, 2, 3 } };
            var polygon = new Polygon(figureType, parties, points);
            double expected = 21.8;

            // act
            double actual = polygon.GetPerimeter();

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Equelse_5and5_TrueReturned()
        {
            // arrange
            var figureType = "Polygon";
            var parties = new List<double>() { 2.8, 9.5, 3.2, 6.3 };
            var points = new int[2, 4] { { 7, 5, 8, 5 }, { 9, 11, 2, 3 } };
            var polygon = new Polygon(figureType, parties, points);
            bool expected = true;

            // act

            bool actual = polygon.Equals(new Polygon(figureType, parties, points));

            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
