using System.Collections.Generic;

namespace Task1_2.Figures.Interfaces
{
    public interface IFigure
    {
        /// <summary>
        /// Figure Type.
        /// Methods for finding the area and perimeter depend on the type of figure.
        /// </summary>
        public string FigureType { get; set; }

        /// <summary>
        /// Parties.
        /// List with the value of the sides of the geometric figure.
        /// </summary>
        /// 
        public List<double> Parties { get; set; }

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
