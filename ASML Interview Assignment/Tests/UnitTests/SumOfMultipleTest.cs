// (C) ASML 2022 Submitted for Interview assignment

using NUnit.Framework;

namespace ASML.InterviewTest.UnitTest
{
    [TestFixture]
    public class SumOfMultipleTest
    {
        [SetUp]
        public void SetUp()
        {
            _sumOfMultipleObj = new SumOfMultiple.SumOfMultiple();
        }

        private SumOfMultiple.SumOfMultiple _sumOfMultipleObj;

        [TestCase(1, 0)]
        [TestCase(2, 0)]
        [TestCase(3, 0)]
        [TestCase(4, 3)]
        [TestCase(5, 3)]
        [TestCase(6, 8)]
        [TestCase(7, 14)]
        [TestCase(8, 14)]
        [TestCase(9, 14)]
        [TestCase(10, 23)]
        [TestCase(11, 33)]
        [TestCase(45662, 486484470)]
        public void Given_Number_Then_GetSumOfAllNumbersWhichAreDivisibleBy3or5BelowTheNumber(int number, decimal sum)
        {
            Assert.AreEqual(sum, _sumOfMultipleObj.ExecuteAlgorithm(number));
        }

        [TestCase(-1, 0)]
        [TestCase(-22, 0)]
        public void Given_NegativeInput_Zero_Is_Returned(int number, decimal sum)
        {
            Assert.AreEqual(sum, _sumOfMultipleObj.ExecuteAlgorithm(number));
        }
    }
}