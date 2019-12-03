using System.Drawing;
using DayThree;
using NUnit.Framework;
using  System.Linq;

namespace DayThreeTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WireMoveRight()
        {
            var wire = new Wire();
            wire.Move('R', 2);
            Assert.That(wire.CoOrdinates.Count, Is.EqualTo(3));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(0,0)),Is.EqualTo(1));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(1,0)),Is.EqualTo(1));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(2,0)),Is.EqualTo(1));
        }

        [Test]
        public void WireMoveLeft()
        {
            var wire = new Wire();
            wire.Move('L', 2);
            Assert.That(wire.CoOrdinates.Count, Is.EqualTo(3));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(0, 0)), Is.EqualTo(1));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(-1, 0)), Is.EqualTo(1));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(-2, 0)), Is.EqualTo(1));
        }

        [Test]
        public void WireMoveUp()
        {
            var wire = new Wire();
            wire.Move('U', 2);
            Assert.That(wire.CoOrdinates.Count, Is.EqualTo(3));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(0, 0)), Is.EqualTo(1));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(0, 1)), Is.EqualTo(1));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(0, 2)), Is.EqualTo(1));
        }

        [Test]
        public void WireMoveDown()
        {
            var wire = new Wire();
            wire.Move('D', 2);
            Assert.That(wire.CoOrdinates.Count, Is.EqualTo(3));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(0, 0)), Is.EqualTo(1));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(0, -1)), Is.EqualTo(1));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(0, -2)), Is.EqualTo(1));
        }

        [Test]
        public void WireMoveAll()
        {
            var wire = new Wire();
            wire.MoveUsingString("D2,R2,U2,L2");
            Assert.That(wire.CoOrdinates.Count, Is.EqualTo(8));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(0, 0)), Is.EqualTo(1));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(0, -1)), Is.EqualTo(1));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(0, -2)), Is.EqualTo(1));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(1, -2)), Is.EqualTo(1));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(2, -2)), Is.EqualTo(1));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(2, -1)), Is.EqualTo(1));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(2, 0)), Is.EqualTo(1));
            Assert.That(wire.CoOrdinates.Count(c => c == new Point(1, 0)), Is.EqualTo(1));
        }
    }
}