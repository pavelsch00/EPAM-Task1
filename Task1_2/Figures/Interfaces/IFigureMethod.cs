using System.Collections.Generic;
/// <summary>
/// Interface describes Figure
/// </summary>
namespace Task1_2
{
    public interface IFigureMethod
    {
        /// <summary>
        /// Perimeter Calculation Method.
        /// </summary>
        public double GetPerimeter();

        /// <summary>
        /// Area Calculation Method.
        /// </summary>
        public double GetArea();
    }
}
