using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_2.Figures.Interfaces
{
    interface IFigureProperties
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
        public List<double> Parties { get; set; }

        public int[,] Points { get; set; }
    }
}
