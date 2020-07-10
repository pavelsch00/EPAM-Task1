using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    /// <summary>
    ///  Class CGD.
    ///   Implements the Euclidean algorithm or Binary GCD algorithm.
    /// </summary>
    public static class CGD
    {
        /// <summary>
        ///  Method EuclideanAlgorithm.
        ///   Finds the GCD of two integers.
        ///   Input data: int, int.
        ///   Output data: int result, double algorithmExecutionTime.
        /// </summary>
        public static (int result, double algorithmExecutionTime) EuclideanAlgorithm(int number1, int number2)
        {
            DateTime StartAlgorithmTime = DateTime.Now;

            if (number1 < 0)
                number1 = Math.Abs(number1);

            if (number2 < 0)
                number2 = Math.Abs(number2);

            while (number2 != 0)
            {
                int temp = number2;
                number2 = number1 % number2;
                number1 = temp;
            }

            return (number1, (DateTime.Now - StartAlgorithmTime).TotalSeconds);
        }

        /// <summary>
        ///  Method EuclideanAlgorithm.
        ///   Finds the GCD of three integers.
        ///   Input data: int, int, int.
        ///   Output data: int result.
        /// </summary>
        public static int EuclideanAlgorithm(int number1, int number2, int number3) => EuclideanAlgorithm(EuclideanAlgorithm(number1, number2).result, number3).result;

        /// <summary>
        ///  Method EuclideanAlgorithm.
        ///   Finds the GCD of four integers.
        ///   Input data: int, int, int, int.
        ///   Output data: int result.
        /// </summary>
        public static int EuclideanAlgorithm(int number1, int number2, int number3, int number4) => EuclideanAlgorithm(EuclideanAlgorithm(number1, number2).result, EuclideanAlgorithm(number3, number4).result).result;

        /// <summary>
        ///  Method EuclideanAlgorithm.
        ///   Finds the GCD of five integers.
        ///   Input data: int, int, int, int, int.
        ///   Output data: int result.
        /// </summary>
        public static int EuclideanAlgorithm(int number1, int number2, int number3, int number4, int number5) => EuclideanAlgorithm(EuclideanAlgorithm(number1, number2, number3, number4), number5).result;

        /// <summary>
        ///  Method BinaryGCD.
        ///   Finds the Binary GCD of two integers and calculates the execution time of the algorithm.
        ///   Input data: int, int.
        ///   Output data: int result, double algorithmExecutionTime.
        /// </summary>
        public static (int result, double algorithmExecutionTime) BinaryGCD(int number1, int number2)
        {
            DateTime StartAlgorithmTime = DateTime.Now;

            if (number1 < 0)
                number1 = Math.Abs(number1);

            if (number2 < 0)
                number2 = Math.Abs(number2);


            if (number1 == 0)
                return (number2, (DateTime.Now - StartAlgorithmTime).TotalSeconds);
            if (number2 == 0)
                return (number1, (DateTime.Now - StartAlgorithmTime).TotalSeconds);

            int i = 0;
            while (((number1 | number2) & 1) == 0)
            {
                number1 >>= 1;
                number2 >>= 1;
                ++i;
            }

            while ((number1 & 1) == 0)
                number1 >>= 1;

            do
            {
                while ((number2 & 1) == 0)
                    number2 >>= 1;

                if (number1 > number2)
                {
                    int temp = number1;
                    number1 = number2;
                    number2 = temp;
                }

                number2 -= number1;
            } while (number2 != 0);

            return (number1 << i, (DateTime.Now - StartAlgorithmTime).TotalSeconds);
        }
    }
}
