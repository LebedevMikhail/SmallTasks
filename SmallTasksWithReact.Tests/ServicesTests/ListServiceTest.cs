using System.Collections.Generic;
using NUnit.Framework;
using SmallTasksWithReact.Core;
using SmallTasksWithReact.Services;

namespace SmallTasksWithReact.Tests.ServicesTests
{
    public class ListServiceTest
    {
        private IListService _service;

        [SetUp]
        public void Setup()
        {
            _service = new ListService();
        }

        [Test]
        public void CorrectArrayWithEqualsLength_ShouldReturnCorrectValue()
        {
            var numberOne = new List<int> {1, 2, 3};
            var numberTwo = new List<int> {1, 2, 3};
            var result = _service.AddLists(numberOne, numberTwo);
            Assert.AreEqual(result, new List<int> {2, 4, 6});
        }
        
        [Test]
        public void CorrectArrayWithWithFirstListLarge_ShouldReturnCorrectValue()
        {
            var numberOne = new List<int> {1, 2, 3, 5};
            var numberTwo = new List<int> {1, 2, 3};
            var result = _service.AddLists(numberOne, numberTwo);
            Assert.AreEqual(result, new List<int> {2, 4, 6, 5});
        }
        
        [Test]
        public void CorrectArrayWithSecondListLarge_ShouldReturnCorrectValue()
        {
            var numberOne = new List<int> {1, 2, 3};
            var numberTwo = new List<int> {1, 2, 3, 5};
            var result = _service.AddLists(numberOne, numberTwo);
            Assert.AreEqual(result, new List<int> {2, 4, 6, 5});
        }
        
        [Test]
        public void CorrectArrays_ShouldReturnCorrectValue()
        {
            var numberOne = new List<int> {1, 2, 3, 5};
            var numberTwo = new List<int> {1, 2, 3, 5, 9};
            var result = _service.AddLists(numberOne, numberTwo);
            Assert.AreEqual(result, new List<int>{2,4,6,0,0,1});
        }
        
        [Test]
        public void CorrectArrayWithFirstListNull_ShouldReturnEmptyList()
        {
            List<int> numberOne = null;
            var numberTwo = new List<int> {1, 2, 3, 5};
            var result = _service.AddLists(numberOne, numberTwo);
            Assert.AreEqual(result, new List<int>());
        }
        
        [Test]
        public void CorrectArrayWithSecondListNull_ShouldReturnEmptyList()
        {
            var numberOne = new List<int> {1, 2, 3, 5};
            List<int> numberTwo = null;
            var result = _service.AddLists(numberOne, numberTwo);
            Assert.AreEqual(result, new List<int>());
        }
        
    }
}