using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    /// <summary>
    ///  Class EuclideanAlgorithm.
    ///   Implements the Euclidean algorithm.
    /// </summary>
    public class EuclideanAlgorithm
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
    }
}
