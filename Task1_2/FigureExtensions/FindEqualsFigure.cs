using System.Linq;
using Task1_2.Figures.Interfaces;

namespace Task1_2.FiguresExtensions
{
    /// <summary>
    ///  Class FindEqualsFigure.
    ///  The class finds all shapes equal to the given.
    /// </summary>
    public class FindEqualsFigure
    {
        /// <summary>
        ///  Method FindEqualsFigures.
        ///  The method finds all the shapes in the array equal to the given.
        ///  Input parameters: IFigure, IFigure[].
        ///  Returned value: IFigure[].
        /// </summary>
        public static IFigure[] FindEqualsFigures(IFigure figure, IFigure[] figures) => figures.Where(obj => obj.Equals(figure)).Select(m => m)?.ToArray();
    }
}