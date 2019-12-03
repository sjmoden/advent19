using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace DayThree
{
    public static class WireComparer
    {
        public static int MinimumTaxicabDistance(List<Point> firstPoints, List<Point> secondPoints)
        {
            return GetClosestDistance(GetTaxicabDistances(GetMatchingPoints(firstPoints, secondPoints)));
        }

        public static int StepsToPoint(List<Point> points, Point pointToFind)
        {
            return points.IndexOf(pointToFind)+1;
        }

        public static int MinimumStepToPoint(List<Point> firstPoints, List<Point> secondPoints)
        {
            var matchingPoints = GetMatchingPoints(firstPoints, secondPoints);

            var distances = matchingPoints.Select(matchingPoint =>
                StepsToPoint(firstPoints, matchingPoint) + StepsToPoint(secondPoints, matchingPoint)).ToList();

            return distances.Min();
        }


        public static List<Point> GetMatchingPoints(List<Point> firstPoints, List<Point> secondPoints)
        {
            return firstPoints.Intersect(secondPoints).ToList();
        }

        public static List<int> GetTaxicabDistances(List<Point> points)
        {
            var distances = new List<int>();
            foreach (var point in points)
            {
                var value = Math.Abs(point.X) + Math.Abs(point.Y);
                distances.Add(value);
            }

            return distances;
        }

        public static int GetClosestDistance(List<int> distances)
        {
            return distances.Min();
        }
    }
}
