using System;
using Xunit;

namespace Task1_1.Tests
{
    public class Task1_1Tests
    {
        [Fact]
        public void EuclideanAlgorithm_80and120_40returned()
        {
            // arrange
            int firstNumber = 80;
            int secondNumber = 120;
            int expected = 40;

            // act
            int actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).result;

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EuclideanAlgorithm_120and80_40returned()
        {
            // arrange
            int firstNumber = 120;
            int secondNumber = 80;
            int expected = 40;

            // act
            int actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).result;

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EuclideanAlgorithm_0and0_0returned()
        {
            // arrange
            int firstNumber = 0;
            int secondNumber = 0;
            int expected = 0;

            // act
            int actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).result;

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EuclideanAlgorithm_10and0_10returned()
        {
            // arrange
            int firstNumber = 10;
            int secondNumber = 0;
            int expected = 10;

            // act
            int actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).result;

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EuclideanAlgorithm_0and15_15returned()
        {
            // arrange
            int firstNumber = 0;
            int secondNumber = 15;
            int expected = 15;

            // act
            int actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).result;

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EuclideanAlgorithm_7and5_1returned()
        {
            // arrange
            int firstNumber = 7;
            int secondNumber = 5;
            int expected = 1;

            // act
            int actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).result;

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EuclideanAlgorithm_minus27and99_9returned()
        {
            // arrange
            int firstNumber = -27;
            int secondNumber = 99;
            int expected = 9;

            // act
            int actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).result;

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EuclideanAlgorithm_27andminus99_9returned()
        {
            // arrange
            int firstNumber = 27;
            int secondNumber = -99;
            int expected = 9;

            // act
            int actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).result;

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EuclideanAlgorithm_minus27andMinus99_9returned()
        {
            // arrange
            int firstNumber = -27;
            int secondNumber = -99;
            int expected = 9;

            // act
            int actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).result;

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EuclideanAlgorithm_0andMinus99_99returned()
        {
            // arrange
            int firstNumber = 0;
            int secondNumber = -99;
            int expected = 99;

            // act
            int actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).result;

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EuclideanAlgorithmCheckTime_0andMinus99_0returned()
        {
            // arrange
            int firstNumber = 0;
            int secondNumber = -99;
            int expected = 0;

            // act
            double actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).algorithmExecutionTime;

            // assert;
            Assert.True(expected < actual);
        }

        [Fact]
        public void EuclideanAlgorithmCheckTime_minus99and0_0returned()
        {
            // arrange
            int firstNumber = -99;
            int secondNumber = 0;
            int expected = 0;

            // act
            double actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).algorithmExecutionTime;

            // assert;
            Assert.True(expected < actual);
        }

        [Fact]
        public void EuclideanAlgorithm_120andMinus9and90_0returned()
        {
            // arrange
            int firstNumber = 120;
            int secondNumber = -9;
            int thirdNumber = 90;
            int expected = 3;

            // act
            double actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber, thirdNumber);

            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
