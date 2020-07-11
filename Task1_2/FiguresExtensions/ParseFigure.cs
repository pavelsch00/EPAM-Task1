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
        public static List<Figure> GetFigures(string path)
        {
            List<Figure> figures = new List<Figure>();
            string figuresType;
            string[] figuresArr = FileExtensions.FileExtension.GetFromFile(path);
            
            string pattern = @"([a-z|A-Z])*";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < figuresArr.Length; i++)
            {
                List<Point> figuresPoints = new List<Point>();
                List<double> figuresSides = new List<double>();

                foreach (Match match in regex.Matches(figuresArr[i]))
                {
                    figuresType = match.Groups[0].Value;

                    string patternPoints = @"(\d+|-\d+)";
                    Regex regexPoints = new Regex(patternPoints);

                    foreach (Match matchPoints in regexPoints.Matches(figuresArr[i]))
                    {
                        for (int k = 0; i < matchPoints.Groups.Count; k++)
                        {
                            if (match.Groups[1].Value == "points")
                            {
                                figuresPoints.Add(new Point(int.Parse(matchPoints.Groups[k].Value), int.Parse(matchPoints.Groups[k + 1].Value)));
                            }
                            else
                            {
                                figuresSides.Add(int.Parse(matchPoints.Groups[k].Value));
                            }
                        }
                    }
                    if (match.Groups[1].Value == "points")
                        figures.Add(new Figure(figuresType, figuresPoints));
                    else
                        figures.Add(new Figure(figuresType, figuresSides));
                }
            }

            return figures;
        }
    }
}
