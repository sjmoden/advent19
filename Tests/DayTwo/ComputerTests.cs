using IntComputer;
using NUnit.Framework;

namespace Tests.DayTwo
{
    public class ComputerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ComputerAddsCorrectly()
        {
            var str = "1,9,10,3,99,3,11,0,99,30,40,50";
            var computer = new IntcodeComputer(str);
            computer.RunAllOperations();
            Assert.That(computer.DisplayCurrentCode, Is.EqualTo("1,9,10,70,99,3,11,0,99,30,40,50"));
        }

        [Test]
        public void ComputerMultipliesCorrectly()
        {
            var str = "2,9,10,3,99,3,11,0,99,30,40,50";
            var computer = new IntcodeComputer(str);
            computer.RunAllOperations();
            Assert.That(computer.DisplayCurrentCode, Is.EqualTo("2,9,10,1200,99,3,11,0,99,30,40,50"));
        }

        [Test]
        public void ComputerComputesMultipleOperations()
        {
            var str = "1,9,10,3,2,3,11,0,99,30,40,50";
            var computer = new IntcodeComputer(str);
            computer.RunAllOperations();
            Assert.That(computer.DisplayCurrentCode, Is.EqualTo("3500,9,10,70,2,3,11,0,99,30,40,50"));
        }

        [Test]
        public void ComputerTest1IsCorrect()
        {
            var str = "1,0,0,0,99";
            var computer = new IntcodeComputer(str);
            computer.RunAllOperations();
            Assert.That(computer.DisplayCurrentCode, Is.EqualTo("2,0,0,0,99"));
        }

        [Test]
        public void ComputerTest2IsCorrect()
        {
            var str = "2,3,0,3,99";
            var computer = new IntcodeComputer(str);
            computer.RunAllOperations();
            Assert.That(computer.DisplayCurrentCode, Is.EqualTo("2,3,0,6,99"));
        }

        [Test]
        public void ComputerTest3IsCorrect()
        {
            var str = "2,4,4,5,99,0";
            var computer = new IntcodeComputer(str);
            computer.RunAllOperations();
            Assert.That(computer.DisplayCurrentCode, Is.EqualTo("2,4,4,5,99,9801"));
        }

        [Test]
        public void ComputerTest4IsCorrect()
        {
            var str = "1,1,1,4,99,5,6,0,99";
            var computer = new IntcodeComputer(str);
            computer.RunAllOperations();
            Assert.That(computer.DisplayCurrentCode, Is.EqualTo("30,1,1,4,2,5,6,0,99"));
        }
    }
}