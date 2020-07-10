using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    /// <summary>
    ///  Class EuclideanAlgorithm.
    ///   Implements the Euclidean algorithm.
    /// </summary>
    public static class EuclideanAlgorithm
    {
        /// <summary>
        ///  Method CalculationOfCGD.
        ///   Finds the GCD of two integers.
        ///   Input data: int, int.
        ///   Output data: int.
        /// </summary>
        public static int CalculationOfGCD(int number1, int number2)
        {
            while(number2 != 0)
            {
                int temp = number2;
                number2 = number1 % number2;
                number1 = temp;
            }

            return number1;
        }

        /// <summary>
        ///  Method CalculationOfCGD.
        ///   Finds the GCD of three integers.
        ///   Input data: int, int, int.
        ///   Output data: int.
        /// </summary>
        public static int CalculationOfGCD(int number1, int number2, int number3) => CalculationOfGCD(CalculationOfGCD(number1, number2), number3);

        /// <summary>
        ///  Method CalculationOfCGD.
        ///   Finds the GCD of four integers.
        ///   Input data: int, int, int, int.
        ///   Output data: int.
        /// </summary>
        public static int CalculationOfGCD(int number1, int number2, int number3, int number4) => CalculationOfGCD(CalculationOfGCD(number1, number2), CalculationOfGCD(number3, number4));

        /// <summary>
        ///  Method CalculationOfCGD.
        ///   Finds the GCD of five integers.
        ///   Input data: int, int, int, int, int.
        ///   Output data: int.
        /// </summary>
        public static int CalculationOfGCD(int number1, int number2, int number3, int number4, int number5) => CalculationOfGCD(CalculationOfGCD(number1, number2, number3, number4), number5);
    }
}
