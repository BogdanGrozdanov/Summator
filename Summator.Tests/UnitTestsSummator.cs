using NUnit.Framework;
using System;

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
        public void Test_Sum_One_Negative_Numbers()
        {
            long actual = Summator.Sum(new long[] { -3 });

            int expected = -3;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_Two_Positive_Numbers()
        {
            long actual = Summator.Sum(new long[] { 1, 3 });

            int expected = 4;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_With_Big_Number()
        {

            long actual = Summator.Sum(new long[] { 1000000000, 1000000000 });

            int expected = 2000000000;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_Two_Negative_Numbers()
        {
            long actual = Summator.Sum(new long[] { -1, -3 });

            int expected = -4;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_With_PositiveAndNegative_Numbers()
        {
            long actual = Summator.Sum(new long[] { -1, 3 });

            int expected = 2;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Average_With_Empty_Arr()
        {
            var arr = new long[] { };
            var actual = Summator.Average(arr);
            Assert.That(actual, Is.EqualTo(0));

            
        }
    }
}