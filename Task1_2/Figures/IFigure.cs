/// <summary>
/// Interface describes Figure
/// </summary>
namespace Task1_2
{
    public interface IFigure
    {
        /// <summary>
        /// Figure Type.
        /// Methods for finding the area and perimeter depend on the type of figure.
        /// </summary>
        public string FigureType { get; set; }

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
