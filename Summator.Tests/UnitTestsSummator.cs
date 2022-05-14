using NUnit.Framework;

namespace Summator.Tests
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void Test_Sum_With_Empty_Arr()
        {
            var arr = new long[] { };

            var result = Summator.Sum(arr);
            var expected = 0;

            Assert.That(result == expected);
        }

        [Test]
        public void Test_Sum_One_Positive_Numbers()
        {
            long actual = Summator.Sum(new long[] { 3 });

            int expected = 3;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_Two_Positive_Numbers()
        {
            long actual = Summator.Sum(new long[] { 1, 3 });

            int expected = 4;

            Assert.That(expected == actual);
        }
    }
}