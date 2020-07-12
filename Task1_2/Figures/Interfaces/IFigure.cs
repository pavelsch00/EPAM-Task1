using System.Collections.Generic;

namespace Task1_2.Figures.Interfaces
{
    /// <summary>
    ///  Interface IFigure.
    ///  The interface describes the fields and methods of figure classes.
    /// </summary>
    public interface IFigure
    {
        #region Properties
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
        #endregion

        #region Methods
        /// <summary>
        /// Perimeter Calculation Method.
        /// Input parameters: null.
        /// Returned value: double.
        /// </summary>
        public double GetPerimeter();

        /// <summary>
        /// Area Calculation Method.
        /// Input parameters: null.
        /// Returned value: double.
        /// </summary>
        public double GetArea();
        #endregion
    }
}
