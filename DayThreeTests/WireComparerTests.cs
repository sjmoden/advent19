using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DayThree;
using NUnit.Framework;

namespace DayThreeTests
{
   public class WireComparerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetClosestDistanceIsCorrect()
        {
            var distances = new List<int>{2,5,7};
            Assert.That(WireComparer.GetClosestDistance(distances), Is.EqualTo(2));
        }

        [Test]
        public void GetTaxicabDistanceIsCorrect()
        {
            var distances = new List<Point> { new Point(3,3)};
            Assert.That(WireComparer.GetTaxicabDistances(distances).Single(), Is.EqualTo(6));
        }

        [Test]
        public void GetMatchingPointsIsCorrect()
        {
            var firstPoints = new List<Point> { new Point(3, 3), new Point(6, 6), new Point(3, 4) };
            var secondPoints = new List<Point> { new Point(3, 3), new Point(6, 6), new Point(3, 6) };
            var intersectPoints = WireComparer.GetMatchingPoints(firstPoints, secondPoints);
            Assert.That(intersectPoints.Count, Is.EqualTo(2));
            Assert.That(intersectPoints.Count(C => C == new Point(3,3)), Is.EqualTo(1));
            Assert.That(intersectPoints.Count(C => C == new Point(6, 6)), Is.EqualTo(1));
        }

        [Test]
        public void TestExample1()
        {
            var wire1 = new Wire();
            wire1.MoveUsingString("R8,U5,L5,D3");

            var wire2 = new Wire();
            wire2.MoveUsingString("U7,R6,D4,L4");

            var distance = WireComparer.MinimumTaxicabDistance(wire1.CoOrdinates, wire2.CoOrdinates);
            Assert.That(distance, Is.EqualTo(6));
        }

        [Test]
        public void TestExample2()
        {
            var wire1 = new Wire();
            wire1.MoveUsingString("R75,D30,R83,U83,L12,D49,R71,U7,L72");

            var wire2 = new Wire();
            wire2.MoveUsingString("U62,R66,U55,R34,D71,R55,D58,R83");

            var distance = WireComparer.MinimumTaxicabDistance(wire1.CoOrdinates, wire2.CoOrdinates);
            Assert.That(distance, Is.EqualTo(159));
        }

        [Test]
        public void TestExample3()
        {
            var wire1 = new Wire();
            wire1.MoveUsingString("R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51");

            var wire2 = new Wire();
            wire2.MoveUsingString("U98,R91,D20,R16,D67,R40,U7,R15,U6,R7");

            var distance = WireComparer.MinimumTaxicabDistance(wire1.CoOrdinates, wire2.CoOrdinates);
            Assert.That(distance, Is.EqualTo(135));
        }

        [Test]
        public void StepsToPointGivesCorrectResult()
        {
            var wire1 = new Wire();
            wire1.MoveUsingString("R8,U5,L5,D3");

            var distance = WireComparer.StepsToPoint(wire1.CoOrdinates, new Point(3,3));
            Assert.That(distance, Is.EqualTo(20));
        }

        [Test]
        public void Test1MinSteps()
        {
            var wire1 = new Wire();
            wire1.MoveUsingString("R8,U5,L5,D3");

            var wire2 = new Wire();
            wire2.MoveUsingString("U7,R6,D4,L4");

            var distance = WireComparer.MinimumStepToPoint(wire1.CoOrdinates, wire2.CoOrdinates);
            Assert.That(distance, Is.EqualTo(30));
        }

        [Test]
        public void Test2MinSteps()
        {
            var wire1 = new Wire();
            wire1.MoveUsingString("R75,D30,R83,U83,L12,D49,R71,U7,L72");

            var wire2 = new Wire();
            wire2.MoveUsingString("U62,R66,U55,R34,D71,R55,D58,R83");

            var distance = WireComparer.MinimumStepToPoint(wire1.CoOrdinates, wire2.CoOrdinates);
            Assert.That(distance, Is.EqualTo(610));
        }

        [Test]
        public void Test3MinSteps()
        {
            var wire1 = new Wire();
            wire1.MoveUsingString("R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51");

            var wire2 = new Wire();
            wire2.MoveUsingString("U98,R91,D20,R16,D67,R40,U7,R15,U6,R7");

            var distance = WireComparer.MinimumStepToPoint(wire1.CoOrdinates, wire2.CoOrdinates);
            Assert.That(distance, Is.EqualTo(410));
        }
    }
}
