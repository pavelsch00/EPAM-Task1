using System;
using System.Collections.Generic;
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
        public void EuclideanAlgorithmTimeCheck_0andMinus99_0returned()
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
        public void EuclideanAlgorithmTimeCheck_minus99and0_0returned()
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

        [Fact]
        public void EuclideanAlgorithm_0andMinus9and90_9returned()
        {
            // arrange
            int firstNumber = 0;
            int secondNumber = -9;
            int thirdNumber = 90;
            int expected = 9;

            // act
            double actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber, thirdNumber);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EuclideanAlgorithm_128andMinus64and16and32_16returned()
        {
            // arrange
            int firstNumber = 128;
            int secondNumber = -64;
            int thirdNumber = 16;
            int fourthNumber = 32;
            int expected = 16;

            // act
            double actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber, thirdNumber, fourthNumber);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EuclideanAlgorithm_0and0and0and0_0returned()
        {
            // arrange
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            int fourthNumber = 0;
            int expected = 0;

            // act
            double actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber, thirdNumber, fourthNumber);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EuclideanAlgorithm_0and9and27and0_9returned()
        {
            // arrange
            int firstNumber = 0;
            int secondNumber = 9;
            int thirdNumber = 27;
            int fourthNumber = 0;
            int expected = 9;

            // act
            double actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber, thirdNumber, fourthNumber);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EuclideanAlgorithm_0and9and27andMinus8_1returned()
        {
            // arrange
            int firstNumber = 0;
            int secondNumber = 9;
            int thirdNumber = 27;
            int fourthNumber = -8;
            int expected = 1;

            // act
            double actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber, thirdNumber, fourthNumber);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EuclideanAlgorithm_0and0and0and0and0_0returned()
        {
            // arrange
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            int fourthNumber = 0;
            int fifthNumberNumber = 0;
            int expected = 0;

            // act
            double actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumberNumber);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EuclideanAlgorithm_117and3and9and0and27_0returned()
        {
            // arrange
            int firstNumber = 117;
            int secondNumber = 3;
            int thirdNumber = 9;
            int fourthNumber = 0;
            int fifthNumberNumber = 27;
            int expected = 3;

            // act
            double actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumberNumber);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EuclideanAlgorithm_minus117and3and9and0andMinus27_0returned()
        {
            // arrange
            int firstNumber = -117;
            int secondNumber = 3;
            int thirdNumber = 9;
            int fourthNumber = 0;
            int fifthNumberNumber = -27;
            int expected = 3;

            // act
            double actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumberNumber);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BinaryGCD_27and99_9returned()
        {
            // arrange
            int firstNumber = 27;
            int secondNumber = 99;
            int expected = 9;

            // act
            double actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).result;

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BinaryGCD_0and13_13returned()
        {
            // arrange
            int firstNumber = 0;
            int secondNumber = 13;
            int expected = 13;

            // act
            double actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).result;

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BinaryGCD_15and0_15returned()
        {
            // arrange
            int firstNumber = 15;
            int secondNumber = 0;
            int expected = 15;

            // act
            double actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).result;

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BinaryGCD_0and0_0returned()
        {
            // arrange
            int firstNumber = 0;
            int secondNumber = 0;
            int expected = 0;

            // act
            double actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).result;

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BinaryGCD_minus18and36_18returned()
        {
            // arrange
            int firstNumber = -18;
            int secondNumber = 36;
            int expected = 18;

            // act
            double actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).result;

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BinaryGCD_minus18andMinus36_2returned()
        {
            // arrange
            int firstNumber = -28;
            int secondNumber = -86;
            int expected = 2;

            // act
            double actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).result;

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BinaryGCD_1and27_1returned()
        {
            // arrange
            int firstNumber = 1;
            int secondNumber = 27;
            int expected = 1;

            // act
            double actual = CGD.EuclideanAlgorithm(firstNumber, secondNumber).result;

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BinaryGCDTimeCheck_minus99and0_0returned()
        {
            // arrange
            int firstNumber = -99;
            int secondNumber = 0;
            int expected = 0;

            // act
            double actual = CGD.BinaryGCD(firstNumber, secondNumber).algorithmExecutionTime;

            // assert;
            Assert.True(expected < actual);
        }

        [Fact]
        public void BinaryGCDTimeCheck_minus99and9_9returned()
        {
            // arrange
            int firstNumber = 99;
            int secondNumber = 9;
            int expected = 0;

            // act
            double actual = CGD.BinaryGCD(firstNumber, secondNumber).algorithmExecutionTime;

            // assert;
            Assert.True(expected < actual);
        }
    }
}
