using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Task1_2.Figures;

namespace Task1_2.FiguresExtensions
{
    public class ParseFigure
    {
        private static List<Figure> Parse(string path)
        {
            List<Figure> figures = new List<Figure>();

            string figuresType;
            string[] figuresArr = FileExtensions.FileExtension.GetFromFile(path);
            string pattern = @"([A-z]+) ([A-z]+)";
            string patternPoints = @"(\d+|-\d+)";

            Regex regex = new Regex(pattern);

            for (int i = 0; i < figuresArr.Length; i++)
            {
                List<double> figuresSides = new List<double>();

                foreach (Match match in regex.Matches(figuresArr[i]))
                {
                    figuresType = match.Groups[1].Value;

                    Regex regexPoints = new Regex(patternPoints);

                    var matchSides = Regex.Matches(figuresArr[i], patternPoints);
                    int[,] points = new int[2, matchSides.Count / 2];
                    for (int k = 0, j = 0; k < matchSides.Count - 1; k += match.Groups[2].Value == "points" ? 2 : 1, j++)
                    {
                        if (match.Groups[2].Value == "points")
                        {
                            points[0, j] = int.Parse(matchSides[j].Groups[0].Value);
                            points[1, j] = int.Parse(matchSides[j + 1].Groups[0].Value);

                            if (k + 2 == matchSides.Count)
                                figuresSides.Add(FindingSideByPoints(int.Parse(matchSides[k].Groups[0].Value), int.Parse(matchSides[k + 1].Groups[0].Value), int.Parse(matchSides[0].Groups[0].Value), int.Parse(matchSides[1].Groups[0].Value)));
                            else
                                figuresSides.Add(FindingSideByPoints(int.Parse(matchSides[k].Groups[0].Value), int.Parse(matchSides[k + 1].Groups[0].Value), int.Parse(matchSides[k + 2].Groups[0].Value), int.Parse(matchSides[k + 3].Groups[0].Value)));
                        }
                        else
                        {
                            figuresSides.Add(int.Parse(matchSides[k].Groups[0].Value));
                        }
                    }

                    if (match.Groups[2].Value == "points")
                        figures.Add(new Figure(figuresType, figuresSides, points));
                    else
                        figures.Add(new Figure(figuresType, figuresSides, null));
                }
            }

            return figures;
        }

        public static List<Figure> GetFigure(string path)
        {
            List<Figure> figures = Parse(path);
            var newFiguresList = new List<Figure>();

            foreach (var item in figures)
            {
                switch (item.FigureType)
                {
                    case "Polygon":
                        newFiguresList.Add(new Polygon(item));
                        break;
                    case "Square":
                        newFiguresList.Add(new Square(item));
                        break;
                    case "Triangle":
                        newFiguresList.Add(new Polygon(item));
                        break;
                    case "Circle":
                        newFiguresList.Add(new Polygon(item));
                        break;
                    case "Rectangle":
                        newFiguresList.Add(new Polygon(item));
                        break;
                }
            }

            return newFiguresList;
        }

        private  static double FindingSideByPoints(int X1, int Y1, int X2, int Y2) => Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
    }
}
