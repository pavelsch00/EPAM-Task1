using Task1_2.FileExtensions;
using Xunit;

namespace Task1_2.Tests.FileExtensionsTest
{
    public class FileExtensionTest
    {
        [Fact]
        public void GetFiguresTest()
        {
            // arrange
            string[] expected = new string[] { "Triangle sides 6, 8, 10", "Square sides 7"};

            // act
            var actual = FileExtension.GetFromFile(@"..\..\..\Resurses\2Figures.txt");

            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
