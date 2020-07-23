using NUnit.Framework;
using SmallTasksWithReact.Core;
using SmallTasksWithReact.Services;

namespace SmallTasksWithReact.Tests.ServicesTests
{
    public class NumberServiceTest
    {
        private INumberService _service;

        [SetUp]
        public void Setup()
        {
            _service = new NumberService();
        }

        [Test]
        public void SumForCorrectArray_ShouldReturnCorrectValue()
        {
            var numbers = new [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
            var result = _service.SumOfEverySecondOddNumber(numbers);
            Assert.AreEqual(result, 36);
        }

        [Test]
        public void SumForIncorrectArray_ShouldReturnZero()
        {
            var numbers = new int[] {};
            var result = _service.SumOfEverySecondOddNumber(numbers);
            Assert.AreEqual(result, 0);
        }
        
        [Test]
        public void SumForNull_ShouldReturnZero()
        {
            var numbers = new int[] {};
            var result = _service.SumOfEverySecondOddNumber(numbers);
            Assert.AreEqual(result, 0);
        }
    }
}