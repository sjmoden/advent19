using DayTwo;
using NUnit.Framework;
namespace DayTwoTests
{
    public class SetUpTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReplaceReplacesCorrectly()
        {
            var str  = "1,9,10,3,99,3,11,0,99,30,40,50";
            var newStr = str.ReplaceMemoryValues(4,444);
            Assert.That(newStr, Is.EqualTo("1,9,10,3,444,3,11,0,99,30,40,50"));
        }
    }
}
